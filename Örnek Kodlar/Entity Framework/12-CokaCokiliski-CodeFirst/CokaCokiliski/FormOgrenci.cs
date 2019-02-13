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
    public partial class FormOgrenci : Form
    {
        public FormOgrenci()
        {
            InitializeComponent();
        }
        UniversiteContext db = DbSingleton.GetInstance();
        private void FormOgrenci_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Ogrenci.ToList();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ogrenci og = new Ogrenci();
            og.Name = txtBoxAd.Text;
            og.SurName = txtBoxSoyad.Text;
            db.Ogrenci.Add(og);
            db.SaveChanges();
            //Egitmen egt = new Egitmen();
            //egt.Name = "AAA";
            //egt.SurName = "BBBB";
            //elist.Add(egt);


            //HashSet<Ogrenci> olist = (HashSet<Ogrenci>)egt.Ogrenci;

            // olist.Add(og);
            dataGridView1.DataSource = db.Ogrenci.ToList();
            
        }
    }
}
