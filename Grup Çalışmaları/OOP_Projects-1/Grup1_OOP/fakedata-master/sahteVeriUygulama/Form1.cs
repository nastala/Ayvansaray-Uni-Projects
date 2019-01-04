using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sahteVeriLib;



namespace sahteVeriUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<genelVeri> genelList = new List<genelVeri>();
        List<ozelVeri> ozelList = new List<ozelVeri>();

        
      
             
        private void Form1_Load(object sender, EventArgs e)
        {




         


        }

        private void button1_Click(object sender, EventArgs e)
        {
            genelVeri gv = new genelVeri();
            ozelVeri ov = new ozelVeri();
            List<Hayvanlar> sonHayvanlar = new List<Hayvanlar>();
            var hayvanlar = gv.hayvanDizi;
            for (int renkSayac = 0; renkSayac < ov.renk.Length; renkSayac++)
            {
                foreach (var hayvan in hayvanlar)
                {
                    Hayvanlar yeniHayvan = new Hayvanlar
                    {
                        hayvanAdi = hayvan.hayvanAdi,
                        ayakSayısı = hayvan.ayakSayısı,
                        ses = hayvan.ses
                    };
                    yeniHayvan.Renk = ov.renk[renkSayac];
                    yeniHayvan.OzelAd = ov.OzelAdUret();
                    yeniHayvan.Yas = ov.YasUret().ToString();
                    sonHayvanlar.Add(yeniHayvan);
                }
            }
            dataGridView1.DataSource = sonHayvanlar;


        }
    }
}
