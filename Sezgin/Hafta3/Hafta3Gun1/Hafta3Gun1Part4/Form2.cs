using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta3Gun1Part4
{
    public partial class Form2 : Form
    {
        public Form1 form1;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            Color c;
            switch (tbColor.Text)
            {
                case "Kırmızı":
                    c = Color.Red;
                    break;
                case "Mavi":
                    c = Color.Blue;
                    break;
                case "Green":
                    c = Color.Green;
                    break;
                default:
                    c = Color.White;
                    break;
            }

            if (c == Color.White)
                MessageBox.Show("Color is undefined!");
            else
            {
                this.Hide();
                form1.BackColor = c;
            }
        }
    }
}
