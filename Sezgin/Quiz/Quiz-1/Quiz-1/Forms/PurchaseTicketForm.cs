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
        }
    }
}
