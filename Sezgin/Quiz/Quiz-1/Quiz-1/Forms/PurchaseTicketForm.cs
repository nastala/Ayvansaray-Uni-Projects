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
    public partial class PurchaseTicketForm : Form
    {
        private Model _model;
        private Bus _selectedBus;
        private City _selectedDepartureCity, _selectedDestinationCity;

        public PurchaseTicketForm()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            _model = new Model();
            _selectedBus = null;
            _selectedDepartureCity = null;
            _selectedDestinationCity = null;

            cbDepartureCities.DisplayMember = "Name";
            cbDepartureCities.ValueMember = "CityID";
            cbDepartureCities.DataSource = _model.Cities.ToList();

            cbDestinationCities.DisplayMember = "Name";
            cbDestinationCities.ValueMember = "CityID";
            cbDestinationCities.DataSource = _model.Cities.ToList();

            cbBusses.DisplayMember = "Plate";
            cbBusses.ValueMember = "BusID";
            cbBusses.DataSource = _model.Busses.ToList();
        }

        private void cbBusses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBusses.SelectedIndex == -1)
                return;

            _selectedBus = (Bus)cbBusses.SelectedItem;
            lblBus.Text = _selectedBus.Name;
            pbBus.Image = (Image)((new ImageConverter()).ConvertFrom(_selectedBus.Image));
            FillSeats();
        }

        private void cbDepartureCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDepartureCities.SelectedIndex == -1)
                return;

            _selectedDepartureCity = (City)cbDepartureCities.SelectedItem;
            FillSeats();
        }

        private void cbDestinationCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDestinationCities.SelectedIndex == -1)
                return;

            _selectedDestinationCity = (City)cbDestinationCities.SelectedItem;
            FillSeats();
        }

        private void FillSeats()
        {
            pnlSeats.Controls.Clear();

            if (_selectedDepartureCity == null || _selectedDestinationCity == null || _selectedBus == null || (_selectedDepartureCity.CityID == _selectedDestinationCity.CityID))
                return;

            int seatCount = _selectedBus.SeatCount;
            Trip trip = _model.Trips.FirstOrDefault(t => t.DepartureCity.CityID == _selectedDepartureCity.CityID && t.ArrivalCity.CityID == _selectedDestinationCity.CityID
                && t.Bus.BusID == _selectedBus.BusID && t.IsLeft == false);

            FillPanel(_selectedBus.SeatCount);

            if (trip != null)
            {
                List<TripDetail> tripDetails = _model.TripDetails.Where(t => t.Trip.TripID == trip.TripID).ToList();
                foreach (TripDetail tripDetail in tripDetails)
                {
                    pnlSeats.Controls[tripDetail.SeatNumber.ToString()].Enabled = false;
                }
            }
        }

        private void FillPanel(int seatCount)
        {
            Button btnSeatSample = new Button
            {
                Width = 55,
                Height = 55
            };

            int x = 0;
            int y = 0;

            for (int i = 1; i <= seatCount; i++)
            {
                Button btnSeatNew = new Button();
                btnSeatNew.Text = i.ToString();
                btnSeatNew.Name = $"{i}";

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
            int seatNumber = Convert.ToInt32(((Button)sender).Text);
            PassengerInfo passengerInfo = new PassengerInfo(seatNumber, this);
            this.Hide();
            passengerInfo.ShowDialog();
        }

        public void PurchaseTicket(Passenger passenger, int seatNumber)
        {
            //MessageBox.Show("Hello from Purchase Ticket");
            Trip trip = _model.Trips.FirstOrDefault(t => t.DepartureCity.CityID == _selectedDepartureCity.CityID && t.ArrivalCity.CityID == _selectedDestinationCity.CityID &&
                t.Bus.BusID == _selectedBus.BusID);

            if (trip == null)
            {
                trip = new Trip()
                {
                    ArrivalCity = _selectedDestinationCity,
                    Bus = _selectedBus,
                    DepartureCity = _selectedDepartureCity,
                    IsLeft = false,
                };

                _model.Trips.Add(trip);
                _model.SaveChanges();
            }

            TripDetail tripDetail = new TripDetail()
            {
                Passenger = passenger,
                Trip = trip,
                SeatNumber = seatNumber
            };

            _model.TripDetails.Add(tripDetail);
            _model.SaveChanges();

            FillSeats();
        }
    }
}
