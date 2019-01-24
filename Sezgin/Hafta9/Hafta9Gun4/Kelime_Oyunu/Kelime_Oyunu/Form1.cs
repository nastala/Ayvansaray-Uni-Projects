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

namespace Kelime_Oyunu
{
    public partial class Form1 : Form
    {
        private SqlConnection _conn;
        private List<string> _productNames;

        public Form1()
        {
            InitializeComponent();
            _conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            _productNames = new List<string>();
            FillProductNames();
        }

        private void FillProductNames()
        {
            _productNames.Clear();

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = new SqlCommand("SELECT ProductName FROM Products WHERE Discontinued = 0", _conn);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            DataTableReader dataTableReader = dataTable.CreateDataReader();
            while (dataTableReader.Read())
            {
                string productName = dataTableReader[0].ToString().Split(' ')[0];
            }
        }
    }
}
