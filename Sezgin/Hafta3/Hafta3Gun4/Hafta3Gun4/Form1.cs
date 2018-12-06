using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta3Gun4
{
    public partial class Form1 : Form
    {
        //Hafta 3, Gün 4, Part 1 <-----> 06.12.2018

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            foreach(Control control in this.Controls)
            {
                if(control is TextBox)
                {
                    control.ForeColor = Color.Red;
                    control.BackColor = Color.Aqua;
                }
            }
        }
    }
}
