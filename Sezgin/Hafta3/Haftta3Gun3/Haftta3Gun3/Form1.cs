using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Haftta3Gun3
{
    public partial class Form1 : Form
    {
        //Hafta3, Gün 3, Part 1 <-----> 05.12.2018
        private Font font;
        private Color color;
        private string name, surname, description;

        public Form1()
        {
            InitializeComponent();

            font = fontDialog1.Font;
            color = colorDialog1.Color;
        }

        private void btnChangeFont_Click(object sender, EventArgs e)
        {
            DialogResult result = fontDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                font = fontDialog1.Font;
                setFont();
            }
        }

        private void setFont()
        {
            tbName.Font = font;
            tbSurname.Font = font;
            tbDescription.Font = font;
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                color = colorDialog1.Color;
                setColor();
            }
        }

        private void setColor()
        {
            tbName.ForeColor = color;
            tbSurname.ForeColor = color;
            tbDescription.ForeColor = color;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
        }

        private void clearTextBoxes()
        {
            tbName.Clear();
            tbSurname.Clear();
            tbDescription.Clear();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(!fillStrings())
            {
                MessageBox.Show("You need to fill Name and Surname Fields");
                return;
            }

            DisplayForm displayForm = new DisplayForm();
            displayForm.font = font;
            displayForm.color = color;
            displayForm.name = name;
            displayForm.surname = surname;
            displayForm.description = description;

            displayForm.Show();
        }

        private bool fillStrings()
        {
            name = tbName.Text;
            surname = tbSurname.Text;
            description = tbDescription.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname))
                return false;

            return true;
        }
    }
}
