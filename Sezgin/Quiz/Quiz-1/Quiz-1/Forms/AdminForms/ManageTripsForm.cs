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

namespace Quiz_1.Forms.AdminForms
{
    public partial class ManageTripsForm : Form
    {
        private Model _model;
        private Trip _selectedTrip;

        public ManageTripsForm()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            _model = new Model();
            _selectedTrip = null;
            dgvTrips.DataSource = _model.Trips.ToList();

            cbDepartureCities.DisplayMember = "Name";
            cbDepartureCities.ValueMember = "CityID";
            cbDepartureCities.DataSource = _model.Cities.ToList();

            cbDestinationCities.DisplayMember = "Name";
            cbDestinationCities.ValueMember = "CityID";
            cbDestinationCities.DataSource = _model.Cities.ToList();

            cbBusses.DisplayMember = "Name";
            cbBusses.ValueMember = "BusID";
            cbBusses.DataSource = _model.Busses.ToList();
        }
    }
}
