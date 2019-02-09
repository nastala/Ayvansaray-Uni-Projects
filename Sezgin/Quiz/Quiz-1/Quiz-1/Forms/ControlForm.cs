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
    public partial class ControlForm : Form
    {
        private Model _model;

        public ControlForm()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            _model = new Model();

            cbBusses.DisplayMember = "Plate";
            cbBusses.ValueMember = "BusID";
            cbBusses.DataSource = _model.Busses.ToList();

            FillLvs();
        }

        private void FillLvs()
        {
            List<Trip> trips = _model.Trips.Where(t => t.IsLeft == false).OrderByDescending(t2 => t2.LastPurchasedTicketTime).ToList();

            trips.ForEach(trip => 
            {
                TripDetail tripDetail = trip.TripDetails.Last();
                lbPlates.Items.Add(trip.Bus.Plate);
                lbSeatNumbers.Items.Add(tripDetail.SeatNumber);
                lbDepartureDestination.Items.Add(trip.DepartureCity.ToString() + " -> " + trip.ArrivalCity.ToString());
                lbNames.Items.Add(tripDetail.Passenger.ToString());
                lbCosts.Items.Add(trip.Bus.Cost);
            });
        }

        private void cbBusses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBusses.SelectedIndex == -1)
                return;

            decimal totalIncome = 0;

            Bus selectedBus = (Bus)cbBusses.SelectedItem;
            Trip trip = _model.Trips.FirstOrDefault(t => t.Bus.BusID == selectedBus.BusID && t.IsLeft == false);

            if (trip != null)
                totalIncome = trip.TripDetails.Count() * selectedBus.Cost;

            tbTotalIncome.Text = totalIncome.ToString();
        }
    }
}
