using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class TargetForm : Form
    {
        public TargetForm()
        {
            InitializeComponent();
        }
        public (string name,float price,float tax) AssignValues
        {
            set
            {
                lName.Text = value.name;
                lPrice.Text = value.price.ToString();
                lTax.Text = value.tax.ToString();
                lFinalPrice.Text = (value.price * value.tax * 0.01f + value.price).ToString();
            }
        }
    }
}
