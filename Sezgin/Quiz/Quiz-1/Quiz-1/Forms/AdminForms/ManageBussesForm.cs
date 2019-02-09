using Quiz_1.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_1.Forms.AdminForms
{
    public partial class ManageBussesForm : Form
    {
        private Model _model;
        private Bus _selectedBus;

        public ManageBussesForm()
        {
            InitializeComponent();
        }

        private void AddBusForm_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void Initialize()
        {
            _model = new Model();
            _selectedBus = null;

            cbDrivers.DisplayMember = "FirstName";
            cbDrivers.ValueMember = "DriverID";
            cbDrivers.DataSource = _model.Drivers.Select(driver => driver).ToList();

            dgvBusses.DataSource = _model.Busses.Select(bus => bus).ToList();
        }

        public byte[] ImageToByteArray(Image image)
        {
            MemoryStream ms = new MemoryStream();

            image.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        private bool CheckInputs()
        {
            if (string.IsNullOrWhiteSpace(tbName.Text))
                return false;

            if (string.IsNullOrWhiteSpace(tbPlate.Text))
                return false;

            //if (!mtbPlate.MaskFull)
            //    return false;

            if (string.IsNullOrWhiteSpace(tbSeatCount.Text))
                return false;

            if (string.IsNullOrWhiteSpace(tbCost.Text))
                return false;

            if (pbImage.Image == null)
                return false;

            try
            {
                Convert.ToInt32(tbSeatCount.Text);
                Convert.ToDecimal(tbCost.Text);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckInputs())
                return;

            if(_selectedBus == null)
            {
                Bus bus = new Bus()
                {
                    Image = Helper.ImageToByteArray(pbImage.Image),
                    Name = tbName.Text,
                    Driver = cbDrivers.SelectedItem != null ? (Driver)cbDrivers.SelectedItem : null,
                    Plate = tbPlate.Text,
                    SeatCount = Convert.ToInt32(tbSeatCount.Text),
                    Cost = Convert.ToDecimal(tbCost.Text)
                };

                _model.Busses.Add(bus);
            }
            else
            {
                _selectedBus.Image = Helper.ImageToByteArray(pbImage.Image);
                _selectedBus.Name = tbName.Text;
                _selectedBus.Driver = cbDrivers.SelectedItem != null ? (Driver)cbDrivers.SelectedItem : null;
                _selectedBus.Plate = tbPlate.Text;
                _selectedBus.SeatCount = Convert.ToInt32(tbSeatCount.Text);
                _selectedBus.Cost = Convert.ToDecimal(tbCost.Text);
            }

            _model.SaveChanges();
            ClearInputs();
        }

        private void ClearInputs()
        {
            Helper.ClearInputs(groupBox1.Controls);
            _selectedBus = null;
            dgvBusses.DataSource = _model.Busses.Select(bus => bus).ToList();
        }

        private void pbImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                lblPath.Text = dialog.FileName;
                pbImage.Image = new Bitmap(dialog.FileName);
            }
        }

        private void dgvBusses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBusses.CurrentRow == null || e.RowIndex == -1)
                return;

            var selectedBus = (Bus)dgvBusses.Rows[e.RowIndex].DataBoundItem;
            if (selectedBus == null)
                return;

            _selectedBus = selectedBus;
            tbName.Text = selectedBus.Name;
            tbPlate.Text = selectedBus.Plate;
            tbSeatCount.Text = selectedBus.SeatCount.ToString();
            cbDrivers.SelectedItem = selectedBus.Driver;
            pbImage.Image = (Image)((new ImageConverter()).ConvertFrom(selectedBus.Image));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedBus == null)
                return;

            DialogResult result = MessageBox.Show($"Are you sure to delete the bus called {_selectedBus.Name}?", "Attention", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _model.Busses.Remove(_selectedBus);
                _model.SaveChanges();
                ClearInputs();
            }
        }
    }
}
