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
    public partial class Form1 : Form
    {
        //Hafta 3, Gün 3, Part 2 FormlarArasiVeriKDV <-----> 05.12.2018
        private string productName;
        private float productValue;
        private float tax;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!fillControl())
                return;

            TaxCalculatorForm form = new TaxCalculatorForm();
            form.fillProperties(productName, productValue, tax);
            form.Show();
        }

        private bool fillControl()
        {
            try
            {
                productName = tbProductName.Text;
                productValue = float.Parse(tbProductValue.Text);
                tax = float.Parse(tbTax.Text);
                return true;
            }
            catch(Exception ex)
            {
                tbProductName.Clear();
                tbProductValue.Clear();
                tbTax.Clear();
                MessageBox.Show("An error occured. Error message: " + ex.Message);
            }

            return false;
        }
    }
}
