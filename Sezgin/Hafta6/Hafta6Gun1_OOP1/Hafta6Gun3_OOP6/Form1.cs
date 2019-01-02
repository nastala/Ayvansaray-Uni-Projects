using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta6Gun3_OOP6
{
    public partial class Form1 : Form
    {
        // İlkel nesne tabanlı programlama 

        int[] id = { 1, 2, 3 };
        string[] ad = { "Ali", "Veli", "Ahmet" };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int girilenId = Int32.Parse(textBox1.Text);
            switch (girilenId)
            {
                case 1:
                    textBox2.Text = ad[0];
                    break;
                case 2:
                    textBox2.Text = ad[1];
                    break;
                case 3:
                    textBox2.Text = ad[2];
                    break;
            }

            //int girilenId = Int32.Parse(textBox1.Text);
            //int index = Array.IndexOf(id, girilenId);
            //textBox2.Text = ad[index];
        }
    }
}
