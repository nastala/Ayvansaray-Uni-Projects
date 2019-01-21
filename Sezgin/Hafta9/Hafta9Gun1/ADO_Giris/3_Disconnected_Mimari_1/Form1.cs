﻿using System;
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

        public Form1()
        {
            InitializeComponent();
            _conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            fillDgvProducts();
        }

        private void fillDgvProducts()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = new SqlCommand("SELECT * FROM Products", _conn);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dgvProducts.DataSource = dataTable;
            dgvProducts.Columns["CategoryID"].Visible = false;
            dgvProducts.Columns["ProductID"].Visible = false;
            dgvProducts.Columns["SupplierID"].Visible = false;
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvProducts.Rows[e.RowIndex].Selected = true;
                tbProductName.Text = dgvProducts.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                nudUnitPrice.Value = (decimal)dgvProducts.Rows[e.RowIndex].Cells["UnitPrice"].Value;
                nudUnitsInStock.Text = dgvProducts.Rows[e.RowIndex].Cells["UnitsInStock"].Value.ToString();
            }
            catch(Exception exc)
            {
                MessageBox.Show("Error message: " + exc.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string productName = tbProductName.Text;
            decimal unitPrice = nudUnitPrice.Value;
            int unitsInStock = (int)nudUnitsInStock.Value;
            if(string.IsNullOrWhiteSpace(productName) || unitPrice < 0 || unitsInStock < 0)
            {
                MessageBox.Show("You entered wrong or empty values");
                return;
            }

            string query = "INSERT INTO Products(ProductName, UnitPrice, UnitsInStock) VALUES(@productName, @unitPrice, @unitsInStock)";
            try
            {
                SqlCommand command = new SqlCommand(query, _conn);
                command.Parameters.Add(new SqlParameter("productName", productName));
                command.Parameters.Add(new SqlParameter("unitPrice", unitPrice));
                command.Parameters.Add(new SqlParameter("unitsInStock", unitsInStock));
                _conn.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if(rowsAffected > 0)
                {
                    fillDgvProducts();
                    MessageBox.Show("Inserted new row successfully");
                }
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}
