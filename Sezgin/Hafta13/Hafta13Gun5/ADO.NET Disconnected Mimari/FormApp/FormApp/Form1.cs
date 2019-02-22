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

namespace FormApp
{
    public partial class Form1 : Form
    {
        private SqlConnection _conn;
        private DataSet _dataSet;

        public Form1()
        {
            InitializeComponent();
            _conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True;");
            _dataSet = new DataSet();
        }

        private void btnFillProducts_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Products";
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, _conn);

                if (_dataSet.Tables.Count > 0 && _dataSet.Tables["Products"] != null)
                    _dataSet.Tables["Products"].Clear();

                dataAdapter.Fill(_dataSet, "Products");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error message: " + exc.Message);
            }
        }

        private void btnBringProducts_Click(object sender, EventArgs e)
        {
            dgvMain.DataSource = null;

            if (_dataSet.Tables.Count < 1 || _dataSet.Tables["Products"] == null)
                return;

            dgvMain.DataSource = _dataSet.Tables["Products"];
            dgvMain.Columns["ProductID"].Visible = false;
        }

        private void btnFillCategories_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Categories";
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, _conn);

                if (_dataSet.Tables.Count > 0 && _dataSet.Tables["Categories"] != null)
                    _dataSet.Tables["Categories"].Clear();

                dataAdapter.Fill(_dataSet, "Categories");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error message: " + exc.Message);
            }
        }

        private void btnBringCategories_Click(object sender, EventArgs e)
        {
            dgvMain.DataSource = null;

            if (_dataSet.Tables.Count < 1 || _dataSet.Tables["Categories"] == null)
                return;

            dgvMain.DataSource = _dataSet.Tables["Categories"];
            dgvMain.Columns["CategoryID"].Visible = false;
        }
    }
}
