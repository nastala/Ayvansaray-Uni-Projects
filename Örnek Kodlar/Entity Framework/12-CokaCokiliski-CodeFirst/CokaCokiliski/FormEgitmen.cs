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
    public partial class FormEgitmen : Form
    {
        public FormEgitmen()
        {
            InitializeComponent();
        }
        UniversiteContext db = DbSingleton.GetInstance();
        private void FormEgitmen_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Egitmen.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Egitmen egt = new Egitmen();
            egt.Name = txtBoxAd.Text;
            egt.SurName = txtBoxSoyad.Text;
            db.Egitmen.Add(egt);
            db.SaveChanges();
            FormEgitmen_Load(null, null);
        }
    }
}
