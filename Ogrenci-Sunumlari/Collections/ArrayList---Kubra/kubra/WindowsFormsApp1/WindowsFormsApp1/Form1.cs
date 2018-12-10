using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }        

        //ArrayList Add
        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList Array = new ArrayList();
            Array.Add(1970);
            Array.Add("Ayşe");
            Array.Add("Fatma");
            Array.Add(2018);
            Array.Add(1987);
            Array.Add("Ahmet");
            Array.Add(1960);
            Array.Add(1994);
            Array.Add("Ali");
            Array.Add("Veli");

            ArrayList.Items.Clear();
            foreach (object dizi in Array)
            {
                ArrayList.Items.Add(dizi);
            }
        }
        //ArrayList Remove
        private void button2_Click(object sender, EventArgs e)
        {
            ArrayList Array = new ArrayList();
            Array.Remove(1970);
            Array.Add(2018);
            Array.Remove(1987);
            Array.Add(1960);
            Array.Add(1994);
            Array.Add("Ayşe");
            Array.Remove("Fatma");
            Array.Add("Ali");
            Array.Add("Veli");
            Array.Remove("Ahmet");
            ArrayList.Items.Clear();
            foreach (object dizi in Array)
            {
                ArrayList.Items.Add(dizi);
            }
        }
        // RemoveAt
        private void button3_Click(object sender, EventArgs e)
        {
            ArrayList Array = new ArrayList();
            Array.Add(1970);
            Array.Add("Ayşe");
            Array.Add("Fatma");
            Array.Add(2018);
            Array.Add(1987);
            Array.Add("Ahmet");
            Array.Add(1960);
            Array.Add(1994);
            Array.Add("Ali");
            Array.Add("Veli");

            Array.RemoveAt(5);
            ArrayList.Items.Clear();
            foreach (object dizi in Array)
            {
                ArrayList.Items.Add(dizi);
            }
        }
        //Sort String
        private void button4_Click(object sender, EventArgs e)
        {
            ArrayList Array = new ArrayList();
            
            Array.Add("Ayşe");
            Array.Add("Fatma");
            Array.Add("Ali");
            Array.Add("Veli");
            Array.Add("Ahmet");
            ArrayList.Items.Clear();
            Array.Sort();
            foreach (object dizi in Array)
            {
                ArrayList.Items.Add(dizi);
            }
        }
        //Sort Int
        private void button5_Click(object sender, EventArgs e)
        {
            ArrayList Array = new ArrayList();
            Array.Add(1970);
            Array.Add(2018);
            Array.Add(1987);
            Array.Add(1960);
            Array.Add(1994);
            Array.Sort();
            ArrayList.Items.Clear();
            foreach (object dizi in Array)
            {
                ArrayList.Items.Add(dizi);
            }
        }
        //Reverse 
        private void button6_Click(object sender, EventArgs e)
        {
            ArrayList Array = new ArrayList();
            Array.Add(1970);
            Array.Add("Ayşe");
            Array.Add("Fatma");
            Array.Add(2018);
            Array.Add(1987);
            Array.Add("Ahmet");
            Array.Add(1960);
            Array.Add(1994);
            Array.Add("Ali");
            Array.Add("Veli");
            Array.Reverse();
            ArrayList.Items.Clear();
            foreach (object dizi in Array)
            {
                ArrayList.Items.Add(dizi);
            }
        }
        //Insert
        private void button7_Click(object sender, EventArgs e)
        {
            ArrayList Array = new ArrayList(10);

            Array.Add("Ayşe");
            Array.Add("Ali");
            Array.Add("Ahmet");
         
            foreach (object dizi in Array)
            {
                ArrayList.Items.Add(dizi);
            }
            Array.Insert(1, "1994");
            Array.Insert(4, "1960");
            Array.Insert(2, "1970");
            ArrayList.Items.Clear();

            foreach (object dizi in Array)
            {
                ArrayList.Items.Add(dizi);
            }

        }
    }
}
