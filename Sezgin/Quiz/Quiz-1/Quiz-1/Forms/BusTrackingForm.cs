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
using System.IO;

namespace Quiz_1.Forms
{
    public partial class BusTrackingForm : Form
    {
        private Model _model;
        private Trip _selectedTrip;
        private List<Trip> _pendingRecords;

        public BusTrackingForm()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            _model = new Model();
            _selectedTrip = null;
            _pendingRecords = new List<Trip>();

            cbBusses.DisplayMember = "Plate";
            cbBusses.ValueMember = "BusID";
            cbBusses.DataSource = _model.Busses.ToList();

            UpdateLbs();
        }

        private void UpdateLbs()
        {
            //List<Trip> trips = _model.Trips.Where(t => t.IsLeft == true).OrderByDescending(t2 => t2.DepartureTime).ToList();
            lbCosts.Items.Clear();
            lbPlates.Items.Clear();
            lbDates.Items.Clear();

            _pendingRecords.ForEach(trip =>
            {
                lbPlates.Items.Add(trip.Bus.Plate);
                lbDates.Items.Add(trip.DepartureTime);
                lbCosts.Items.Add(trip.Bus.Cost * trip.TripDetails.Count());
            });
        }

        private void cbBusses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBusses.SelectedIndex == -1)
                return;

            Bus bus = (Bus)cbBusses.SelectedItem;
            _selectedTrip = _model.Trips.FirstOrDefault(t => t.IsLeft == false && t.Bus.BusID == bus.BusID);

            if (_selectedTrip != null && _pendingRecords.Contains(_selectedTrip) == false)
            {
                tbPassengerCount.Text = _selectedTrip.TripDetails.Count().ToString();
                tbTrip.Text = _selectedTrip.DepartureCity.ToString() + " -> " + _selectedTrip.ArrivalCity.ToString();
            }
            else
                ClearInputs();
        }

        private void ClearInputs()
        {
            _selectedTrip = null;
            tbPassengerCount.Text = null;
            tbTrip.Text = null;

            UpdateLbs();
        }

        private void btnBusLeft_Click(object sender, EventArgs e)
        {
            if (_selectedTrip == null)
                return;

            _selectedTrip.IsLeft = true;
            _selectedTrip.DepartureTime = DateTime.Now;
            _pendingRecords.Add(_selectedTrip);
            
            ClearInputs();
        }

        private void btnSaveBusState_Click(object sender, EventArgs e)
        {
            if (_pendingRecords.Count < 1)
                return;

            string path = System.AppDomain.CurrentDomain.BaseDirectory + @"records\DailyArchive.txt";
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                _pendingRecords.ForEach(record =>
                {
                    writer.WriteLine($"Plate: {record.Bus.Plate} Date: {record.DepartureTime} Total Income: {record.Bus.Cost * record.TripDetails.Count}");
                });

                _model.SaveChanges();
                ClearPendingRecords();

                MessageBox.Show("Records are saved successfully");
            }
        }

        private void ClearPendingRecords()
        {
            _pendingRecords = new List<Trip>();
            UpdateLbs();
        }

        private void btnDailyArchive_Click(object sender, EventArgs e)
        {
            lbDailyRecordArchive.Items.Clear();
            List<Trip> dailyRecords = _model.Trips.Where(t => t.IsLeft == true && t.DepartureTime >= DateTime.Today).ToList();
            dailyRecords.ForEach(record => lbDailyRecordArchive.Items.Add($"Plate: {record.Bus.Plate} Date: {record.DepartureTime} Total Income: {record.Bus.Cost * record.TripDetails.Count}"));
        }
    }
}
