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

namespace Hafta3Gun2
{
    public partial class Form1 : Form
    {
        //Hafta 3, Gün 2, Part 1 <-----> 04.12.2018
        string itemText;
        byte boomNumber;
        byte count = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private bool timerCheck()
        {
            bool timerCheck, boomNumberCheck;
            if (timer1.Enabled)
            {
                tbBoomNumber.Clear();
                MessageBox.Show("Timer is already running right now!");
                timerCheck = false;
            }
            else
                timerCheck = true;

            if (boomNumber <= 0)
            {
                tbBoomNumber.Clear();
                MessageBox.Show("Boom number must be greater than 0");
                boomNumberCheck = false;
            }
            else
                boomNumberCheck = true;

            return timerCheck && boomNumberCheck;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!timerCheck())
                return;

            if(fillBoomNumber())
                timer1.Start();
        }

        private bool fillBoomNumber()
        {
            lbBoomNumbers.BackColor = Color.White;
            lbBoomNumbers.Items.Clear();

            try
            {
                boomNumber = byte.Parse(tbBoomNumber.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("You must enter a number");
            }
            catch (OverflowException)
            {
                MessageBox.Show("The number is too big.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unknown error occured! Error: " + ex.Message);
            }
            finally
            {
                tbBoomNumber.Clear();
            }

            return false;
        }

        private void timerBoom()
        {
            if (count > 100)
            {
                timer1.Stop();
                count = 1;
                return;
            }

            if (count % boomNumber == 0)
            {
                lbBoomNumbers.BackColor = Color.Red;
                lbBoomNumbers.ForeColor = Color.White;
                itemText = "BOOM";
            }
            else
            {
                lbBoomNumbers.BackColor = Color.White;
                lbBoomNumbers.ForeColor = Color.Black;
                itemText = count.ToString();
            }

            lbBoomNumbers.Items.Add(itemText);
            lbBoomNumbers.TopIndex = count - 1;
            count++;
        }

        private void forBoom()
        {
            for(int i = 1; i <= 100; i++)
            {
                if (i % boomNumber == 0)
                {
                    lbBoomNumbers.BackColor = Color.Red;
                    lbBoomNumbers.ForeColor = Color.White;
                    itemText = "BOOM";
                }
                else
                {
                    lbBoomNumbers.BackColor = Color.White;
                    lbBoomNumbers.ForeColor = Color.Black;
                    itemText = i.ToString();
                }

                lbBoomNumbers.Items.Add(itemText);
                lbBoomNumbers.TopIndex = i - 1;

                this.Update();
                Thread.Sleep(100);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (!timerCheck())
                return;

            lbBoomNumbers.BackColor = Color.White;
            lbBoomNumbers.Items.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerBoom();
        }

        private void btnForStart_Click(object sender, EventArgs e)
        {
            lbBoomNumbers.Items.Clear();
            if(fillBoomNumber())
                forBoom();
        }
    }
}
