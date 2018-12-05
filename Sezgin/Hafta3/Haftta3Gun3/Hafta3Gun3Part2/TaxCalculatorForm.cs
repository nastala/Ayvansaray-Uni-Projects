using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta3Gun3Part2
{
    public partial class TaxCalculatorForm : Form
    {
        private string productName;
        private float value, tax;

        public TaxCalculatorForm()
        {
            InitializeComponent();
        }

        private void fillLabels()
        {
            lblProductName.Text = productName;
            lblFinalValue.Text = (value + (value * tax / 100)).ToString();
        }

        private void TaxCalculatorForm_Load(object sender, EventArgs e)
        {
            fillLabels();
        }

        public void fillProperties(string productName, float value, float tax)
        {
            this.productName = productName;
            this.value = value;
            this.tax = tax;
        }
    }
}
