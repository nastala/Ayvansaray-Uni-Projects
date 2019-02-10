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
using Newtonsoft.Json;

namespace JsonListView
{
    public partial class FormJsonGoruntule : Form
    {
        public FormJsonGoruntule()
        {
            InitializeComponent();
        }

        string jsonlistpath = @"C:\Ogrenci\JsonOgrenciList.txt";
        List<Ogrenci> Ogrencilistesi = new List<Ogrenci>();

        private void FormJsonGoruntule_Load(object sender, EventArgs e)
        {
            string veri = "";

            if(!File.Exists(jsonlistpath)){

                MessageBox.Show("Böyle Bir dosya Yok");

            }else
            {

                FileStream dosya = File.OpenRead(jsonlistpath);

                StreamReader dosyaOku = new StreamReader(dosya);
                veri = dosyaOku.ReadToEnd();
                dosyaOku.Close();
                dosyaOku.Dispose();
                dosya.Close();

                Ogrencilistesi =(List<Ogrenci>) JsonConvert.DeserializeObject(veri, typeof(List<Ogrenci>));
                ListeYazdir();

              
            }
            
            
        }

        private void ListeYazdir()
        {
            foreach (Ogrenci ogrenci in Ogrencilistesi)
            {
                ListViewItem Kayit = new ListViewItem();
                Kayit.Text = ogrenci.Ad;
                Kayit.SubItems.Add(ogrenci.Soyad);
                Kayit.SubItems.Add(ogrenci.Yas.ToString());
                lstOgrenciListe.Items.Add(Kayit);
            }
        }
    }
}
