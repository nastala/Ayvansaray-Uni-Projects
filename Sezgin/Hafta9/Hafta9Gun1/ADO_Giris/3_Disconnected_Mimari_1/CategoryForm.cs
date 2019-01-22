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
    public partial class CategoryForm : Form
    {
        private SqlConnection _conn;

        public CategoryForm()
        {
            InitializeComponent();
            _conn = new SqlConnection("Data Source=localhost;Initial Catalog=Northwind;Integrated Security=True");
            FillDgvCategories();
        }

        private void FillDgvCategories()
        {
            string query = "SELECT * FROM Categories";
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, _conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvCategories.DataSource = dataTable;
                dgvCategories.Columns["CategoryID"].Visible = false;
            }
            catch(Exception exc)
            {
                MessageBox.Show("Error message: " + exc.Message);
            }
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvCategories.Rows[e.RowIndex].Selected = true;
                tbCategoryName.Text = dgvCategories.Rows[e.RowIndex].Cells["CategoryName"].Value.ToString();
                tbDescription.Text = dgvCategories.Rows[e.RowIndex].Cells["Description"].Value.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error message: " + exc.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string categoryName = tbCategoryName.Text;
            string description = tbDescription.Text;
            if(string.IsNullOrWhiteSpace(categoryName) || string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Please enter valid texts");
                return;
            }

            string query = "INSERT INTO Categories(CategoryName, Description) VALUES(@categoryName, @description)";
            try
            {
                SqlCommand command = new SqlCommand(query, _conn);
                command.Parameters.Add(new SqlParameter("categoryName", categoryName));
                command.Parameters.Add(new SqlParameter("description", description));
                _conn.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if(rowsAffected > 0)
                {
                    MessageBox.Show("New row added successfully");
                    FillDgvCategories();
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("Error message: " + exc.Message);
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}
