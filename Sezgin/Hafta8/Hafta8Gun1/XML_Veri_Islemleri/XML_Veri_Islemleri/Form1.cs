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
using System.Xml.XPath;

namespace XML_Veri_Islemleri
{
    public partial class Form1 : Form
    {
        string dosyaYolu = Application.StartupPath + "\\CalisanListesi.xml";
        const string veritabani = "server=.;Database=Northwind;trusted;connection=true";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            wbVeriler.Url = new Uri(dosyaYolu);
        }

        private void btnVeriOku_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(dosyaYolu);
            dgvVeriler.DataSource = ds.Tables[0];
            // wbVeriler.Url = new Uri(dosyaYolu);
        }

        private void btnVeriBul_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(dosyaYolu);
            XmlNode secilenNode = xmlDoc.ChildNodes[1];
            bool bulundu = false;

            foreach (XmlNode item in secilenNode)
            {
                if(item.ChildNodes[0].InnerText.Equals("Can") || item.Attributes["TCNo"].Value.Equals("12345678901"))
                {
                    MessageBox.Show("Aranan kişi foreach yaparak bulundu. \n\n"
                        + item.ChildNodes[0].InnerText + " "
                        + item.ChildNodes[1].InnerText + "\n"
                        + item.ChildNodes[2].InnerText + "\n"
                        + "TCNo: " + item.Attributes["TCNo"].Value);
                    bulundu = true;
                    break;
                }
            }

            if (!bulundu)
            {
                MessageBox.Show("Aranan kişi bulunamadı");
            }
        }

        private void btnXPathIleTagBul_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(dosyaYolu);
            XmlNode secilenNode = xmlDoc.SelectSingleNode("Calisanlar/Calisan[Adi='Melek']");
            //XmlNode secilenNode = xmlDoc.SelectSingleNode("Calisanlar/Calisan[@TCNo=12345678902]");

            if (secilenNode != null)
            {
                MessageBox.Show("Aranan kisi XPath ile kolayca bulundu:\n\n"
                    + secilenNode.ChildNodes[0].InnerText + " "
                    + secilenNode.ChildNodes[1].InnerText + "\n"
                    + secilenNode.ChildNodes[2].InnerText + "\n"
                    + "TCNo: " + secilenNode.Attributes["TCNo"].Value);
            }
            else
            {
                MessageBox.Show("Aranan kisi 'Melek' bulunamadi.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            wbVeriler.Url = new Uri(dosyaYolu);
        }

        private void btnXPathIleVerileriBul_Click(object sender, EventArgs e)
        {
            XPathDocument xmlDoc = new XPathDocument(dosyaYolu);
            XPathNavigator xmlNav = xmlDoc.CreateNavigator();
            XPathNodeIterator secilenNode = xmlNav.Select("Calisanlar/Calisan/Adi");

            string metin = "";
            while (secilenNode.MoveNext())
            {
                if (secilenNode.Current.InnerXml.StartsWith("C"))
                    metin += secilenNode.Current.InnerXml + "\n";
            }

            if (!string.IsNullOrEmpty(metin))
                MessageBox.Show("Adı C ile başlayanlar: \n\n" + metin);
            else
                MessageBox.Show("Adı C ile başlayan bulunamadı.");
        }
    }
}
