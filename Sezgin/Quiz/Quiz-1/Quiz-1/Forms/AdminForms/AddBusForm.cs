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
    public partial class AddBusForm : Form
    {
        private Model _model;

        public AddBusForm()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            _model = new Model();

            cbDrivers.DisplayMember = "FirstName";
            cbDrivers.ValueMember = "DriverID";
            cbDrivers.DataSource = _model.Drivers;
        }

        private void pbImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                lblPath.Text = dialog.FileName;
                pbImage.Image = new Bitmap(dialog.FileName);
            }
        }

        public byte[] ImageToByteArray(Image bitmap)
        {
            MemoryStream ms = new MemoryStream();

            bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CheckInputs())
                return;

            Bus bus = new Bus()
            {
                Image = ImageToByteArray(pbImage.Image),
                Name = tbName.Text,
                DriverID = cbDrivers.SelectedIndex,
                Plate = mtbPlate.Text,
                SeatCount = Convert.ToInt32(tbSeatCount)
            };

            _model.Busses.Add(bus);
            _model.SaveChanges();

            ClearInputs();
        }

        private void ClearInputs()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox || control is MaskedTextBox)
                    control.Text = "";
                else if (control is ComboBox)
                    ((ComboBox)control).SelectedIndex = -1;
                else if (control is PictureBox)
                    ((PictureBox)control).Image = null;
            }
        }

        private bool CheckInputs()
        {
            if (string.IsNullOrWhiteSpace(tbName.Text))
                return false;

            if (string.IsNullOrWhiteSpace(tbPlate.Text))
                return false;

            if (!mtbPlate.MaskFull)
                return false;

            if (string.IsNullOrWhiteSpace(tbSeatCount.Text))
                return false;

            try
            {
                Convert.ToInt32(tbSeatCount.Text);
            }
            catch
            {
                return false;
            }

            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }
    }
}
