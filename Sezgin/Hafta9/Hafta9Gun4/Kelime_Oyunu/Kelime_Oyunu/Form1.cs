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
            throw new NotImplementedException();
        }
    }
}
