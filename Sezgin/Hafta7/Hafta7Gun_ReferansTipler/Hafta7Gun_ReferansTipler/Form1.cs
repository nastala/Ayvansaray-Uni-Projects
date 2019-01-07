using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta7Gun_ReferansTipler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button b1 = new Button();
            b1.Text = "Button 1";

            Button b2 = b1;
            b2.Text = "Button 2";

            MessageBox.Show(string.Format("B1: {0}, B2: {1}", b1.Text, b2.Text));
        }
    }
}
