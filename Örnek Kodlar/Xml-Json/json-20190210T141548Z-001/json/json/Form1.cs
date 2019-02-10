using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
namespace json
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txt_ad.KeyPress += YalnizHarf;
            txt_soyad.KeyPress += YalnizHarf;
            txt_yas.KeyPress += YalnizTc;
        }

        string JsonFilePath = "C:\\Ogrenci\\JsonOgrenci.txt";
        string JsonFilePathList = "C:\\Ogrenci\\OgrenciList.txt";
        List<Ogrenci> OgrList = new List<Ogrenci>();
        List<Ogrenci> Ogrenciliste = new List<Ogrenci>();
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (txt_ad.Text != "" && txt_soyad.Text != "" && txt_yas.Text != "")
            {
                try
                {
                    Ogrenci ogrenci = new Ogrenci();
                    ogrenci.Ad = txt_ad.Text;
                    ogrenci.Soyad = txt_soyad.Text;
                    ogrenci.Yas = Convert.ToInt32(txt_yas.Text);
                    OgrList.Add(ogrenci);
                    listBox1.Items.Add(ogrenci.Ad.Substring(0, 1).ToUpper() + ogrenci.Ad.Substring(1) + " " + ogrenci.Soyad.ToUpper() + " " + ogrenci.Yas);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Boşluk Bırakmayınız..");
            }
        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                OgrList.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void YalnizHarf(object sender, KeyPressEventArgs e)
        {//txt_ad a ve txt_soyad a yalnızca harf girişini kontol ediyoruz.
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }
        public void YalnizTc(object sender, KeyPressEventArgs e)
        {//txt_txno ya yalnızca numerik değer girilmesini sağlayacak metotu yazdık.
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void btnserial_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = txt_ad.Text;
            ogrenci.Soyad = txt_soyad.Text;
            ogrenci.Yas = Convert.ToInt32(txt_yas.Text);

            FileStream dosya = File.Open(JsonFilePath, FileMode.OpenOrCreate);//filestream tipinde bir dosya oluşturdu
            StreamWriter SWriter = new StreamWriter(dosya);
            SWriter.Write(JsonConvert.SerializeObject(ogrenci));
            SWriter.Close();
            SWriter.Dispose();
            dosya.Close();
            webBrowser1JSON.Url = new Uri(JsonFilePath);
            MessageBox.Show("Başarılı ile kaydedildi...");
        }
        private void btndeserial_Click(object sender, EventArgs e)
        {
            if (!File.Exists(JsonFilePath))
            {
                MessageBox.Show("Böyle bir doysa yok");
            }
            else
            {
                FileStream dosya = File.OpenRead(JsonFilePath);
                StreamReader streader = new StreamReader(dosya);
                string dosyaicerigi = streader.ReadToEnd();
                streader.Close();
                streader.Dispose();
                dosya.Close();

                webBrowser1JSON.Url = new Uri(JsonFilePath);

                Ogrenci ogrenci = (Ogrenci)JsonConvert.DeserializeObject(dosyaicerigi, typeof(Ogrenci));
                txt_ad.Text = ogrenci.Ad;
                txt_soyad.Text = ogrenci.Soyad;
                txt_yas.Text = ogrenci.Yas.ToString();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txt_ad.Clear();
            txt_soyad.Clear();
            txt_yas.Clear();
        }
        private void btnserializellist_Click(object sender, EventArgs e)
        {
            FileStream dosya = File.Open(JsonFilePathList, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(dosya);
            sw.WriteLine(JsonConvert.SerializeObject(OgrList));
            sw.Close();
            sw.Dispose();
            dosya.Close();
            webBrowser1JSON.Url = new Uri(JsonFilePathList);
            MessageBox.Show("Başarılı Bir Şekilde Kaydedildi...");
        }

        private void btn_deserialize_Click(object sender, EventArgs e)
        {
            if (!File.Exists(JsonFilePathList))
            {
                MessageBox.Show("Böyle bir doysa yok");
            }
            else
            {
                FileStream dosya = File.OpenRead(JsonFilePathList);
                StreamReader dosyaOku = new StreamReader(dosya);

                string veri = dosyaOku.ReadToEnd();
                dosya.Close();
                dosyaOku.Close();
                webBrowser1JSON.Url = new Uri(JsonFilePathList);
                dosyaOku.Dispose();
            //    Ogrenciliste = (List<Ogrenci>)JsonConvert.DeserializeObject(veri, typeof(List<Ogrenci>));
                List<Ogrenci> OgrenciListe  = JsonConvert.DeserializeObject<List<Ogrenci>>(veri);
                for (int i = 0; i < OgrenciListe.Count; i++)
                {
                    ListViewItem Kayıt = new ListViewItem();
                    Kayıt.Text = OgrenciListe[i].Ad;
                    Kayıt.SubItems.Add(OgrenciListe[i].Soyad);
                    Kayıt.SubItems.Add(OgrenciListe[i].Yas.ToString());
                    listView1.Items.Add(Kayıt);
                }
            }
        }
       
        private void btnLabTemizle_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void btnDosya_Click(object sender, EventArgs e)
        {
            File.Delete(JsonFilePath);
            File.Delete(JsonFilePathList);
            MessageBox.Show("Dosya Başarılı Bir şekilde silindi");
        }
    }
}
