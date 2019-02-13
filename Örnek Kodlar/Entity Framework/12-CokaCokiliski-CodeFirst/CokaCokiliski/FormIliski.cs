using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CokaCokiliski
{
    public partial class FormIliski : Form
    {
        public FormIliski()
        {
            InitializeComponent();
        }
        UniversiteContext db = DbSingleton.GetInstance();
        

        private void FormIliski_Load(object sender, EventArgs e)
        {
            listBox1.DisplayMember = "Name";
            listBox1.DataSource = db.Ogrenci.ToList();
            cmboBoxEgitmen.DisplayMember = "Name";
            cmboBoxEgitmen.DataSource = db.Egitmen.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Egitmen seciliEgitmen = cmboBoxEgitmen.SelectedItem as Egitmen;
            var egitmen = db.Egitmen.Find(seciliEgitmen.Id);
            foreach (Ogrenci item in listBox1.SelectedItems)
            {
                egitmen.Ogrenci.Add(item);
            }
            db.SaveChanges();

            listBox1.SelectedItems.Clear();
            dataGridView1.DataSource = egitmen.Ogrenci.ToList();
        }

        private void cmboBoxEgitmen_SelectedIndexChanged(object sender, EventArgs e)
        {
            Egitmen seciliEgitmen = cmboBoxEgitmen.SelectedItem as Egitmen;
            var egitmeninOgrencileri = db.Egitmen.Find(seciliEgitmen.Id).Ogrenci.ToList();
            dataGridView1.DataSource = egitmeninOgrencileri;
        }
    }
}
