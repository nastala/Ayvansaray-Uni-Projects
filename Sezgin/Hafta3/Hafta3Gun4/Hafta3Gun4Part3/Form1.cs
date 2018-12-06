using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta3Gun4Part3
{
    public partial class Form1 : Form
    {
        //Hafta 3, Gün 4, Part 3 <-----> 06.12.2018

        private int[] iArray = new int[] { 10, 20, 25, 28, 34 };
        private int iToplam;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            lbFor.Items.Clear();
            iToplam = 0;

            for(int i = 0; i < iArray.Length; i++)
            {
                iToplam += iArray[i];
                lbFor.Items.Add(iArray[i]);
            }

            lbFor.Items.Add("Sum: " + iToplam);
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            lbWhile.Items.Clear();
            int count = 0;
            iToplam = 0;

            while(count < iArray.Length)
            {
                iToplam += iArray[count];
                lbWhile.Items.Add(iArray[count]);
                count++;
            }

            lbWhile.Items.Add("Sum: " + iToplam);
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            lbDoWhile.Items.Clear();
            int count = 0;
            iToplam = 0;

            do
            {
                iToplam += iArray[count];
                lbDoWhile.Items.Add(iArray[count]);
                count++;
            } while (count <= iArray.Length - 1);

            lbDoWhile.Items.Add("Sum: " + iToplam);
        }

        private void btnForeach_Click(object sender, EventArgs e)
        {
            lbForeach.Items.Clear();
            iToplam = 0;

            foreach(int i in iArray)
            {
                iToplam += i;
                lbForeach.Items.Add(i);
            }

            lbForeach.Items.Add("Sum: " + iToplam);
        }

        private void btnEnumerator_Click(object sender, EventArgs e)
        {
            lbEnumerator.Items.Clear();
            iToplam = 0;

            IEnumerator enumerator = iArray.GetEnumerator();
            while (enumerator.MoveNext())
            {
                iToplam += (int)enumerator.Current;
                lbEnumerator.Items.Add(enumerator.Current);
            }

            lbEnumerator.Items.Add("Sum: " + iToplam);
        }
    }
}
