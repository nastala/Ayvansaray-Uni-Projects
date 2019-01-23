using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_Disconnected_Mimari_1
{
    public partial class Form1 : Form
    {
        private SqlConnection _conn;
        private int _selectedProductID;

        public Form1()
        {
            InitializeComponent();
            _conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            _selectedProductID = -1;
            dgvProducts.ContextMenuStrip = cmsDgvProducts;
            FillDgvProducts();
        }

        private void FillDgvProducts()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = new SqlCommand("SELECT * FROM Products WHERE Discontinued = 0", _conn);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dgvProducts.DataSource = dataTable;
            dgvProducts.Columns["CategoryID"].Visible = false;
            dgvProducts.Columns["ProductID"].Visible = false;
            dgvProducts.Columns["SupplierID"].Visible = false;
            ClearSelectionsOfDgvProducts();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvProducts.Rows[e.RowIndex].Selected = true;
                tbProductName.Text = dgvProducts.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                nudUnitPrice.Value = (decimal)dgvProducts.Rows[e.RowIndex].Cells["UnitPrice"].Value;
                nudUnitsInStock.Text = dgvProducts.Rows[e.RowIndex].Cells["UnitsInStock"].Value.ToString();
                _selectedProductID = (int)dgvProducts.Rows[e.RowIndex].Cells["ProductID"].Value;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error message: " + exc.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string productName = tbProductName.Text;
            decimal unitPrice = nudUnitPrice.Value;
            int unitsInStock = (int)nudUnitsInStock.Value;
            if (string.IsNullOrWhiteSpace(productName) || unitPrice < 0 || unitsInStock < 0)
            {
                MessageBox.Show("You entered wrong or empty values");
                return;
            }

            string query = "INSERT INTO Products(ProductName, UnitPrice, UnitsInStock) VALUES(@productName, @unitPrice, @unitsInStock)";
            try
            {
                SqlCommand command = new SqlCommand(query, _conn);
                command.Parameters.Add(new SqlParameter("@productName", productName));
                command.Parameters.Add(new SqlParameter("@unitPrice", unitPrice));
                command.Parameters.Add(new SqlParameter("@unitsInStock", unitsInStock));
                _conn.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    FillDgvProducts();
                    MessageBox.Show("New row inserted successfully");
                }
            }
            finally
            {
                _conn.Close();
            }
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string productName = tbProductName.Text;
            decimal unitPrice = nudUnitPrice.Value;
            int unitsInStock = (int)nudUnitsInStock.Value;
            if (string.IsNullOrWhiteSpace(productName) && unitPrice < 0 && unitsInStock < 0)
            {
                MessageBox.Show("You entered wrong or empty values");
                return;
            }

            if (_selectedProductID == -1)
            {
                MessageBox.Show("Please select the row you want to save!");
                return;
            }

            string query = "UPDATE Products SET ProductName = @productName, UnitPrice = @unitPrice, UnitsInStock = @unitsInStock WHERE ProductID = @productID";
            try
            {
                SqlCommand command = new SqlCommand(query, _conn);
                command.Parameters.Add(new SqlParameter("@productName", productName));
                command.Parameters.Add(new SqlParameter("@unitPrice", unitPrice));
                command.Parameters.Add(new SqlParameter("@unitsInStock", unitsInStock));
                command.Parameters.Add(new SqlParameter("@productID", _selectedProductID));
                _conn.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    FillDgvProducts();
                    MessageBox.Show("Row updated successfully");
                }
            }
            finally
            {
                _conn.Close();
            }
        }

        private void cmsProductsDelete_Click(object sender, EventArgs e)
        {
            if (_selectedProductID == -1) return;

            DialogResult result = MessageBox.Show($"Do you want to delete selected row?(index: { _selectedProductID})", "Attention", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                var dbD = new DatabaseDeleteObject("Products", "ProductID", _selectedProductID);
                int returnValue = DeleteFrom(dbD, out var hasError);

                if (hasError == true && returnValue == 547)
                {
                    DialogResult result2 = MessageBox.Show("The product you want to delete is related to other entries on the database. Do you want to delete them too?",
                    "Attention", MessageBoxButtons.YesNoCancel);
                    if (result2 == DialogResult.Yes)
                    {
                        var dbOD = new DatabaseDeleteObject("[Order Details]", "ProductID", _selectedProductID);

                        DeleteFrom(dbOD, out _);
                        DeleteFrom(dbD, out _);

                        FillDgvProducts();
                    }
                    else if (result2 == DialogResult.No)
                    {
                        var duo = new DatabaseUpdateObject("Products", "ProductID", _selectedProductID, ("Discontinued", 1));
                        UpdateFrom(duo, out hasError);

                        if (hasError == false)
                        {
                            FillDgvProducts();
                        }
                    }
                }
            }

        }

        private int DeleteFrom(DatabaseDeleteObject dbD, out bool hasError)
        {
            string query = string.Format("DELETE FROM {0} WHERE {1} = {2}", dbD.TableName, dbD.ColumnName, dbD.DeleteId);
            hasError = false;
            try
            {
                SqlCommand command = new SqlCommand(query, _conn);
                _conn.Open();

                return command.ExecuteNonQuery();
            }
            catch (SqlException exc)
            {
                hasError = true;
                return exc.Number;
            }
            finally
            {
                _conn.Close();
            }
        }

        private int DeleteFrom(string tableName, string parameterName, object parameterValue, out bool hasError)
        {
            string query = string.Format("DELETE FROM {0} WHERE {1} = {2}", tableName, parameterName, parameterValue);
            hasError = false;
            try
            {
                SqlCommand command = new SqlCommand(query, _conn);
                _conn.Open();

                return command.ExecuteNonQuery();
            }
            catch (SqlException exc)
            {
                hasError = true;
                return exc.Number;
            }
            finally
            {
                _conn.Close();
            }
        }

        private int UpdateFrom(DatabaseUpdateObject duo, out bool hasError)
        {
            hasError = false;
            var query = new StringBuilder($"UPDATE { duo.TableName} ");
            foreach (var columnAndValue in duo.ColumnsAndValues)
            {
                query.Append($"SET {columnAndValue.ColumnName} = {columnAndValue.ColumnValue}, ");
            }
            query = query.Remove(query.Length - 2, 1);
            query.Append($"WHERE {duo.ColumnName} = {duo.UpdateId}");

            try
            {
                var command = new SqlCommand(query.ToString(), _conn);
                _conn.Open();

                return command.ExecuteNonQuery();
            }
            catch (SqlException exc)
            {
                hasError = true;
                return exc.ErrorCode;
            }
            finally
            {
                _conn.Close();
            }
        }

        internal struct DatabaseDeleteObject
        {
            public DatabaseDeleteObject(string tableName, string columnName, int deleteId) : this()
            {
                ColumnName = columnName;
                TableName = tableName;
                DeleteId = deleteId;
            }

            public string ColumnName { get; set; }
            public string TableName { get; set; }
            public int DeleteId { get; set; }
        }

        internal struct DatabaseUpdateObject
        {
            public DatabaseUpdateObject(string tableName,  string columnName, int updateId, params (string, object)[] setValues) : this()
            {
                ColumnName = columnName;
                TableName = tableName;
                UpdateId = updateId;
                ColumnsAndValues = setValues;
            }

            public string ColumnName { get; set; }
            public string TableName { get; set; }
            public int UpdateId { get; set; }
            public (string ColumnName, object ColumnValue)[] ColumnsAndValues { get; set; }
        }

        private void dgvProducts_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                ClearSelectionsOfDgvProducts();
                dgvProducts.Rows[e.RowIndex].Selected = true;
                _selectedProductID = (int)dgvProducts.Rows[e.RowIndex].Cells["ProductID"].Value;
            }
        }

        private void ClearSelectionsOfDgvProducts()
        {
            _selectedProductID = -1;

            for (int i = 0; i < dgvProducts.SelectedRows.Count; i++)
            {
                dgvProducts.SelectedRows[i].Selected = false;
            }
        }
    }
}
