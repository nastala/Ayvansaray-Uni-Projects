using FirmaKayit.Hangar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirmaKayit.Hangar;

namespace FirmaKayit
{
    public partial class AnaSayfa : Form

    {
        Formlar _f = new Formlar();
        mesajlar _m = new mesajlar();

        public static int Aktarma = -1;

        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            groupBox1.Text = "Bilgi Giriş Ekranı";
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            // Close();
            Application.Exit();
        }

        private void btnBilgiGiris_Click(object sender, EventArgs e)
        {
            //propotise yaptığımız event özelliği bir kerelik old. için buraya yazıyoruz.
            pnl1.Visible = true;
            pnl2.Visible = false;
            pnl3.Visible = false;
            groupBox1.Text = "Bilgi Giriş Ekranı";
            groupBox1.ForeColor = Color.Navy;
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba");
            pnl1.Visible = false;
            pnl2.Visible = true;
            pnl3.Visible = false;
            groupBox1.Text = "Form-2 Ekranı";
            groupBox1.ForeColor = Color.Orange;
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = true;
            groupBox1.Text = "Form-3 Ekranı";
            groupBox1.ForeColor = Color.Plum;
        }

        private void btnFrmGir_Click(object sender, EventArgs e)
        {
            _f.FrmGir();
        }
    }
}
