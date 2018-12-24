using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1_FirmaKayit
{
    public partial class AnaSayfa : Form
    {
        enum Paneller
        {
            Panel1,
            Panel2,
            Panel3
        }

        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            setVisibilityOfPanels(Paneller.Panel1);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBilgiGiris_Click(object sender, EventArgs e)
        {
            setVisibilityOfPanels(Paneller.Panel1);
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            setVisibilityOfPanels(Paneller.Panel2);
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            setVisibilityOfPanels(Paneller.Panel3);
        }

        private void setVisibilityOfPanels(AnaSayfa.Paneller paneller)
        {
            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = false;

            switch (paneller)
            {
                case Paneller.Panel1:
                    pnl1.Visible = true;
                    groupBox1.Text = "Bilgi Giriş Ekranı";
                    groupBox1.ForeColor = Color.Navy;
                    break;
                case Paneller.Panel2:
                    pnl2.Visible = true;
                    groupBox1.Text = "Form 2";
                    groupBox1.ForeColor = Color.Crimson;
                    break;
                case Paneller.Panel3:
                    pnl3.Visible = true;
                    groupBox1.Text = "Form 3";
                    groupBox1.ForeColor = Color.Aqua;
                    break;
            }
        }
    }
}
