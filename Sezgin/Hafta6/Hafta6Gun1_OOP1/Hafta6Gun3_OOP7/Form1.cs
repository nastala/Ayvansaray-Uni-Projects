using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta6Gun3_OOP7
{
    public partial class Form1 : Form
    {
        List<Classlar.Ogrenci> ogrenciler = new List<Classlar.Ogrenci>();
        Classlar.Ogrenci secilenOgrenci;
        int idCount;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDoldur_Click(object sender, EventArgs e)
        {
            Doldur();
        }

        private void Doldur()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ogrenciler;

            int ogrenciSayisi = ogrenciler.Count();
            int toplamMaas = ogrenciler.Sum(ogrenci => ogrenci.Maas);
            tbToplamMaas.Text = toplamMaas.ToString();
            tbOgrenciSayisi.Text = ogrenciSayisi.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            idCount = 2;
            Classlar.Ogrenci ogrenci1 = new Classlar.Ogrenci(1, "Sezgin", "Yağlı", 100);
            Classlar.Ogrenci ogrenci2 = new Classlar.Ogrenci(2, "Hasan", "Veli", 200);
            ogrenciler.Add(ogrenci1);
            ogrenciler.Add(ogrenci2);
            Doldur();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            secilenOgrenci = (Classlar.Ogrenci)dataGridView1.CurrentRow.DataBoundItem;
            tbAd.Text = secilenOgrenci.Ad;
            tbSoyad.Text = secilenOgrenci.Soyad;
            tbMaas.Text = secilenOgrenci.Maas.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = tbAd.Text;
            string soyad = tbSoyad.Text;
            int maas = Int32.Parse(tbMaas.Text);
            idCount++;
            Classlar.Ogrenci yeniOgrenci = new Classlar.Ogrenci(idCount, ad, soyad, maas);
            ogrenciler.Add(yeniOgrenci);
            Doldur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenOgrenci == null)
                return;
            ogrenciler.Remove(secilenOgrenci);
            secilenOgrenci = null;
            Doldur();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenOgrenci == null)
                return;
            int index = ogrenciler.IndexOf(secilenOgrenci);
            string ad = tbAd.Text;
            string soyad = tbSoyad.Text;
            int maas = Int32.Parse(tbMaas.Text);
            secilenOgrenci = new Classlar.Ogrenci(secilenOgrenci.Id, ad, soyad, maas);
            ogrenciler[index] = secilenOgrenci;
            Doldur();
        }
    }
}
