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
        private int _stepCount;

        public Form1()
        {
            InitializeComponent();
            _conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            _productNames = new List<string>();
            _stepCount = 1;
            FillProductNames();
        }

        private void FillProductNames()
        {
            _productNames.Clear();

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = new SqlCommand("SELECT ProductName FROM Products", _conn);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            DataTableReader dataTableReader = dataTable.CreateDataReader();
            while (dataTableReader.Read())
            {
                string productName = dataTableReader[0].ToString().Split(' ')[0];
                _productNames.Add(productName);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string text = tbFirstChar.Text;

            if (string.IsNullOrWhiteSpace(text))
            {
                return;
            }

            ClearValues();

            char firstChar = text.ElementAt(0);
            StartGame(firstChar, _productNames);
        }

        private void StartGame(char charElem, List<string> names)
        {
            string foundedName = names.FirstOrDefault(productNames => productNames.ToLower().StartsWith(charElem.ToString().ToLower()));

            if (string.IsNullOrWhiteSpace(foundedName))
            {
                MessageBox.Show("Game Over!");
                return;
            }

            foundedName = foundedName.Split(' ')[0];
            lbHistory.Items.Add($"Step_{_stepCount} - {foundedName}");
            lbSteps.Items.Add(foundedName);
            names.Remove(foundedName);
            _stepCount++;

            StartGame(foundedName.ElementAt(foundedName.Length - 1), names);
        }

        private void ClearValues()
        {
            _stepCount = 1;
            lbHistory.Items.Clear();
            lbSteps.Items.Clear();
        }
    }
}
