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
        public MainForm()
        {
            InitializeComponent();
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

        private void btnControl_Click(object sender, EventArgs e)
        {
            ControlForm controlForm = new ControlForm();
            controlForm.Show();
        }

        private void btnBusTracking_Click(object sender, EventArgs e)
        {
            BusTrackingForm busTrackingForm = new BusTrackingForm();
            busTrackingForm.Show();
        }
    }
}
