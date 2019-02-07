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

        public PurchaseTicketForm()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            _model = new Model();
            _selectedBus = null;

            cbDepartureCities.DisplayMember = "Name";
            cbDepartureCities.ValueMember = "CityID";
            cbDepartureCities.DataSource = _model.Cities.ToList();

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
        }
    }
}
