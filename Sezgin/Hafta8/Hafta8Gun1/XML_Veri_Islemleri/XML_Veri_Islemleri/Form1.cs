﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
        const string veritabani = "Data Source=localhost;Initial Catalog=Northwind;Integrated Security=True";

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

        private void btnVeriDegistir_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(dosyaYolu);
            XmlNode secilenNode = xmlDoc.SelectSingleNode("Calisanlar/Calisan[Adi='Melek']");

            if(secilenNode != null)
            {
                secilenNode.ChildNodes[1].InnerText += secilenNode.ChildNodes[1].InnerText.Contains("Galip") ? "" : " Galip";
                xmlDoc.Save(dosyaYolu);
            }

            wbVeriler.Url = new Uri(dosyaYolu);
        }

        private void btnXmlVeriSil_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(dosyaYolu);
            XmlNode secilenNode = xmlDoc.SelectSingleNode("Calisanlar/Calisan[Adi='Melek']");

            if(secilenNode != null)
            {
                xmlDoc.DocumentElement.RemoveChild(secilenNode);
                xmlDoc.Save(dosyaYolu);
                MessageBox.Show("Melek adlı çalışan silindi.");
            }
            else
            {
                MessageBox.Show("Melek adlı çalışan bulunamadı");
            }

            wbVeriler.Url = new Uri(dosyaYolu);
        }

        private void btnAddChild_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(dosyaYolu);
            XmlElement yeniEleman = xmlDoc.CreateElement("Calisan");
            XmlAttribute attrTCNO = xmlDoc.CreateAttribute("TCNo");
            attrTCNO.Value = "12345678904";
            yeniEleman.Attributes.Append(attrTCNO);

            XmlNode xNodeAdi = xmlDoc.CreateElement("Adi");
            xNodeAdi.InnerText = "Buse";
            yeniEleman.AppendChild(xNodeAdi);

            XmlNode xNodeSoyadi = xmlDoc.CreateElement("Soyadi");
            xNodeSoyadi.InnerText = "Zengin";
            yeniEleman.AppendChild(xNodeSoyadi);

            xmlDoc.DocumentElement.AppendChild(yeniEleman);
            xmlDoc.Save(dosyaYolu);
            MessageBox.Show("Buse eklendi");
            wbVeriler.Url = new Uri(dosyaYolu);
        }

        private void btnSqlToXml_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(veritabani);
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Products", con);
            DataTable dt = new DataTable("Product");
            dataAdapter.Fill(dt);
            DataSet ds = new DataSet("Products");
            ds.Tables.Add(dt);

            FolderBrowserDialog fd = new FolderBrowserDialog();
            DialogResult dr = fd.ShowDialog();
            if(dr == DialogResult.OK)
            {
                string dosya = fd.SelectedPath + "\\SQLtoXML.xml";
                ds.WriteXml(dosya);
                MessageBox.Show("SQL'den gelen veriler XML dosyasına yazıldı.\n" + dosya);
                wbVeriler.Url = new Uri(dosya);
            }
            else
                MessageBox.Show("Hata meydana geldi");
        }

        private void btnXmlToSql_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            DialogResult result = fd.ShowDialog();
            if(result == DialogResult.OK)
            {
                string dosya = fd.SelectedPath + "\\SQLtoXML.xml";

                if (File.Exists(dosya))
                {
                    SqlConnection conn = new SqlConnection(veritabani);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from ProductsX", conn);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                    DataSet dataSet = new DataSet();
                    dataSet.ReadXml(dosya);
                    dataAdapter.Update(dataSet.Tables[0]);

                    MessageBox.Show("XML'den okunan veriler ProductsX tablosuna kaydedildi");
                    wbVeriler.Url = new Uri(dosya);
                }
                else
                {
                    MessageBox.Show("Dosya bulunamadı. \n" + dosya);
                }
            }
        }

        private void btnSchemaOlustur_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(veritabani);
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select ProductID, ProductName, UnitPrice from Products", conn);
            DataTable dataTable = new DataTable("XProduct");
            dataAdapter.Fill(dataTable);
            DataSet dataSet = new DataSet("XProducts");
            dataSet.Tables.Add(dataTable);

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                string dosya = dialog.SelectedPath + "\\mySchema.xsd";
                dataSet.WriteXmlSchema(dosya);
                MessageBox.Show("SQL'den gelen sorguya göre XML şema bilgisi dosyaya yazıldı");
                wbVeriler.Url = new Uri(dosya);
            }
        }

        private void btnSqlToSchema_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "XML schema dosyasının bulunduğu klasörü seçiniz";
            DialogResult result = dialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                string secilenDosya = dialog.SelectedPath + "\\mySchema.xsd";
                if(File.Exists(secilenDosya))
                {
                    //Farkli bir veritabanından xml şemasına uygun olarak veri alınıyor.
                    SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=pubs;Integrated Security=True");
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("select pub_id AS ProductID, title AS ProductName, price AS UnitePrice from titles", conn);
                    DataTable dataTable = new DataTable("XProduct");
                    //Şemayı kullanarak veri okuması gerekiyor
                    dataTable.ReadXmlSchema(secilenDosya);
                    dataAdapter.Fill(dataTable);
                    DataSet dataSet = new DataSet("XProducts");
                    dataSet.Tables.Add(dataTable);

                    FolderBrowserDialog dialog2 = new FolderBrowserDialog();
                    DialogResult result2 = dialog2.ShowDialog();
                    if(result2 == DialogResult.OK)
                    {
                        string xmlDosya = dialog2.SelectedPath + "\\semaya_uygun_veri.xml";
                        dataSet.WriteXml(xmlDosya);
                        MessageBox.Show("SQL'den gelen sorguya göre XML şema bilgisi dosyaya yazıldı \n" + xmlDosya);
                        wbVeriler.Url = new Uri(xmlDosya);
                    }
                }
                else
                {
                    MessageBox.Show("XML şema dosyası bulunamadı. \n" + secilenDosya);
                }
            }
        }
    }
}
