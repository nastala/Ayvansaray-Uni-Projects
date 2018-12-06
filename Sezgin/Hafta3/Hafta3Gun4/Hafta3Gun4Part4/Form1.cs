using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta3Gun4Part4
{
    public partial class Form1 : Form
    {
        //Hafta 3, Gün 4, Part 4 <-----> 06.12.2018

        private int buttonCounter = 1;
        private List<Button> buttons = new List<Button>();
        private int y = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int x;
            if (buttonCounter % 2 == 0)
                x = 87;
            else
            {
                y = 42 * (buttonCounter / 2);
                x = 0;
            }

            if (y > panel1.Height)
            {
                MessageBox.Show("You can not add a button any more!");
                return;
            }

            Button button = new Button();
            button.Parent = panel1;
            button.Location = new Point(x, y);
            button.Height = 40;
            button.Width = 80;
            button.Text = "Button " + buttonCounter;
            button.Click += (bS, bE) =>
            {
                MessageBox.Show("You cliked on " + ((Button)bS).Text);
            };
            buttons.Add(button);
            panel1.Controls.AddRange(buttons.ToArray());
            buttonCounter++;
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            DialogResult result = colorDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                foreach (Button button in buttons)
                    button.BackColor = colorDialog.Color;
            }
        }
    }
}
