using Quiz_1.Classes;
using Quiz_1.Forms;
using Quiz_1.Forms.AdminForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_1
{
    public partial class MainForm : Form
    {
        private Model _model;

        public MainForm()
        {
            InitializeComponent();

            FillPanel();

            _model = new Model();
        }

        private void FillPanel()
        {
            Button btnSeatSample = new Button();
            btnSeatSample.Width = 55;
            btnSeatSample.Height = 55;

            int x = 0;
            int y = 0;

            for (int i = 1; i <= 50; i++)
            {
                Button btnSeatNew = new Button();
                btnSeatNew.Text = i.ToString();

                switch (i % 3)
                {
                    case 0:
                        y = (btnSeatNew.Height + 5) * 2 + 20;
                        break;
                    case 1:
                        y = 0;

                        if (i != 1)
                            x += btnSeatNew.Width + 5;
                        break;
                    case 2:
                        y = btnSeatNew.Height + 5;
                        break;
                }

                btnSeatNew.Location = new Point(x, y);
                btnSeatNew.Click += HandleSeat_Click;

                pnlSeats.Controls.Add(btnSeatNew);
            }
        }

        private void HandleSeat_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((Button)sender).Text);
        }

        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            AdminMainForm adminMainForm = new AdminMainForm();
            adminMainForm.Show();
        }

        private void btnPurchaseTicket_Click(object sender, EventArgs e)
        {
            PurchaseTicketForm purchaseTicketForm = new PurchaseTicketForm();
            purchaseTicketForm.Show();
        }
    }
}
