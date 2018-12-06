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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            using (var form = new TargetForm())
            {
                form.AssignValues = (tBName.Text, float.Parse(tBPrice.Text), float.Parse(tBTax.Text));
                form.ShowDialog();
            }
        }
    }
}
