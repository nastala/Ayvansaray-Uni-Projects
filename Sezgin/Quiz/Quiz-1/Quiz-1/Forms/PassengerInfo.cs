using Quiz_1.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_1.Forms
{
    public partial class PassengerInfo : Form
    {
        private int _seatNumber;
        private PurchaseTicketForm _purchaseTicketForm;

        public PassengerInfo(int seatNumber, PurchaseTicketForm purchaseTicketForm)
        {
            InitializeComponent();

            _seatNumber = seatNumber;
            _purchaseTicketForm = purchaseTicketForm;
            Initialize();
        }

        private void Initialize()
        {
            lblSeatNumber.Text = _seatNumber.ToString();
            cbGender.DataSource = Enum.GetValues(typeof(Helper.Gender));
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (!CheckInputs())
                return;

            Passenger passenger = new Passenger()
            {
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                Gender = (Helper.Gender)cbGender.SelectedItem,
                IdentityNumber = mtbIdentityNumber.Text
            };

            this.Close();
            _purchaseTicketForm.PurchaseTicket(passenger, _seatNumber);
        }

        private bool CheckInputs()
        {
            if (string.IsNullOrWhiteSpace(tbFirstName.Text))
                return false;

            if (string.IsNullOrWhiteSpace(tbLastName.Text))
                return false;

            if (!mtbIdentityNumber.MaskCompleted)
                return false;

            if (cbGender.SelectedItem == null)
                return false;

            return true;
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGender.SelectedIndex == -1)
                return;

            Helper.Gender gender;
            Enum.TryParse<Helper.Gender>(cbGender.SelectedValue.ToString(), out gender);
        }

        protected override void DestroyHandle()
        {
            _purchaseTicketForm.Show();
        }
    }
}
