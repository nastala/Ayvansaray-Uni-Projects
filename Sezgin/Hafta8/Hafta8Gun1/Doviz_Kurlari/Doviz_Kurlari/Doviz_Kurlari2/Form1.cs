using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Doviz_Kurlari2.Classlar;

namespace Doviz_Kurlari2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            lbDoviz.Items.Clear();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("http://www.tcmb.gov.tr/kurlar/today.xml");
            XmlElement rootElement = xmlDoc.DocumentElement;
            XmlNodeList liste = rootElement.GetElementsByTagName("Currency");
            List<Doviz> kurlar = new List<Doviz>();

            foreach(var item in liste)
            {
                Doviz doviz = new Doviz();
                XmlElement currency = (XmlElement)item;
                string isim = currency.GetElementsByTagName("Isim").Item(0).InnerText;

                doviz.DovizAd = isim;
                string alisFiyat = currency.GetElementsByTagName("ForexBuying").Item(0).InnerText;
                string satisFiyat = currency.GetElementsByTagName("ForexSelling").Item(0).InnerText;
                string birim = currency.GetElementsByTagName("Unit").Item(0).InnerText;

                if (!string.IsNullOrEmpty(alisFiyat))
                {
                    doviz.AlisFiyat = Convert.ToDecimal(alisFiyat);
                }
                
                if(!string.IsNullOrEmpty(satisFiyat))
                {
                    doviz.SatisFiyat = Convert.ToDecimal(satisFiyat);
                }

                if (!string.IsNullOrEmpty(birim))
                {
                    doviz.Birim = Convert.ToInt32(birim);
                }

                kurlar.Add(doviz);
                lbDoviz.Items.Add(doviz);
            }

            dgvKur.DataSource = kurlar;
            int i = 0;
            foreach(var item in kurlar)
            {
                try
                {
                    dgvDoviz.Rows.Add();
                    dgvDoviz.Rows[i].Cells[0].Value = item.DovizAd;
                    dgvDoviz.Rows[i].Cells[1].Value = item.SatisFiyat;
                    i++;
                }
                catch (Exception)
                {
                    MessageBox.Show("Hello from the other side!");
                }
            }
        }

        private void lbDoviz_SelectedIndexChanged(object sender, EventArgs e)
        {
            Doviz secilenDoviz = new Doviz();

            if(lbDoviz.SelectedIndex != -1)
                secilenDoviz = (Doviz)lbDoviz.Items[lbDoviz.SelectedIndex];

            if(secilenDoviz != null)
            {
                lblBirim.Text = secilenDoviz.Birim.ToString();
                lblDovizAlis.Text = secilenDoviz.AlisFiyat.ToString();
                lblDovizSatis.Text = secilenDoviz.SatisFiyat.ToString();
            }
        }
    }
}
