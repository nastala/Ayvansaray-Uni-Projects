using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta3Gun5Part3
{
    public partial class Form1 : Form
    {
        //Hafta 3, Gün 5, Part 3 <-----> 07.12.2018
        private DateTime selectedDate, startDate;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initializeVars();
        }

        private void initializeVars()
        {
            this.Text = DateTime.Now.ToString();
            timer1.Interval = 1000;
            startDate = DateTime.Now;
            dtpDate.MinDate = startDate;
            mtbTime.Text = startDate.Hour + startDate.Minute + "";
        }

        private void btnSaveStart_Click(object sender, EventArgs e)
        {
            selectedDate = dtpDate.Value;
        }
    }
}
