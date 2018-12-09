using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Hafta3Gun5Part3
{
    public partial class Form1 : Form
    {
        //Hafta 3, Gün 5, Part 3 <-----> 07.12.2018
        private DateTime selectedDate, startDate;
        private double diffMillis, counterMillis;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initializeVars();
        }

        public void initializeVars()
        {
            string text = "";
            this.Text = DateTime.Now.ToString();
            timer1.Interval = 1000;
            startDate = DateTime.Now;
            dtpDate.MinDate = startDate;
            text += startDate.Hour + ":";
            if (startDate.Minute < 10)
                text += "0";
            text += startDate.Minute;
            mtbTime.Text = text;
            counterMillis = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counterMillis >= diffMillis)
            {
                timer1.Stop();
                notifyIcon1.Visible = false;
                AlarmForm alarmForm = new AlarmForm();
                alarmForm.PrevForm = this;
                alarmForm.Description = selectedDate.ToString() + " Alarm";
                alarmForm.ShowDialog();
            }
            else
                counterMillis += 1000;
        }

        private void btnSaveStart_Click(object sender, EventArgs e)
        {
            if (checkEnteredValues())
            {
                this.Hide();
                notifyIcon1.Visible = true;
                diffMillis = (new TimeSpan((selectedDate - startDate).Ticks)).TotalMilliseconds;
                timer1.Start();
            }
            else
                initializeVars();
        }

        private bool checkEnteredValues()
        {
            DateTime tempDate;
            startDate = DateTime.Now;
            string[] hourAndMinute = mtbTime.Text.Split(':');
            tempDate = dtpDate.Value;
            selectedDate = new DateTime(tempDate.Year, tempDate.Month, tempDate.Day, Int32.Parse(hourAndMinute[0]), 
                Int32.Parse(hourAndMinute[1]), 0);

            if(selectedDate <= startDate)
            {
                MessageBox.Show("Entered date values are invalid. Please enter a valid date!");
                return false;
            }

            return true;
        }
    }
}
