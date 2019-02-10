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
    public partial class FormJsonOlustur : Form
    {
        public FormJsonOlustur()
        {
            InitializeComponent();
        }
        string jsonlistpath = @"C:\Ogrenci\JsonOgrenciList.txt";
        List<Ogrenci> OgrenciList = new List<Ogrenci>();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            if(txtAd.Text!=""&&txtSoyad.Text!=""&&txtYas.Text!=""){
            try
            {
                ogrenci.Ad = txtAd.Text;
                ogrenci.Soyad = txtSoyad.Text;
                ogrenci.Yas = Convert.ToInt32(txtYas.Text);
                listeElemanEkle(ogrenci);
                OgrenciList.Add(ogrenci);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            }else{

                MessageBox.Show("Bosluk Girmeyiniz");
            }
            
        }
        private void listeElemanEkle(Ogrenci ogrenci)
        {
            ListViewItem kayit = new ListViewItem();
            kayit.Text = ogrenci.Ad;
            kayit.SubItems.Add(ogrenci.Soyad);
            kayit.SubItems.Add(ogrenci.Yas.ToString());
            lstOgrenci.Items.Add(kayit);
        }

        private void btnSerialize_Click(object sender, EventArgs e)
        {
            FileStream dosya = File.Open(jsonlistpath, FileMode.OpenOrCreate);
            StreamWriter dosyayaz = new StreamWriter(dosya);

            dosyayaz.Write(JsonConvert.SerializeObject(OgrenciList));
            dosyayaz.Close();
            dosyayaz.Dispose();
            dosya.Close();

            MessageBox.Show("Ogrenci Listesi Başarıyla Kaydedildi");

        }

    }
}
