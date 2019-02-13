using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IK_Uygulama_CodeFirst
{
    public partial class FormPersonel : Form
    {
        public FormPersonel()
        {
            InitializeComponent();
        }

        PersonelContext db = new PersonelContext();
        int secilenID;
        private void FormPersonel_Load(object sender, EventArgs e)
        {
            combodoldur();
            datadoldur();
        }
        private void datadoldur()
        {
            dataGridView1.DataSource = db.Personeller.Select(x => new
            {
                x.PersonelID,
                Ad_Soyad = x.Ad + " " + x.Soyad,
                x.DogumTarihi,
                Egitim = x.egitim.Aciklama,
                E_mail = x.Email,
                Adres = x.Adres,
                Ilce = x.ilce.Aciklama,
                Il = x.ilce.il.Aciklama,
                x.Maas,
                Unvan = x.unvan.Aciklama,
                Yoneticisi = x.yonetici.Ad + " " + x.yonetici.Soyad,
                Yonetici_Mi = x.YoneticiMi
            }).ToList();
        }

        private void combodoldur()
        {
            cmbegitim.DataSource = db.Egitimler.ToList();
            cmbegitim.DisplayMember = "Aciklama";
            cmbegitim.ValueMember = "ID";
            cmbegitim.Text = "Seçiniz";

            cmbunvan.DataSource = db.Unvanlar.ToList();
            cmbunvan.DisplayMember = "Aciklama";
            cmbunvan.ValueMember = "ID";
           cmbunvan.Text = "Seçiniz";

            cmbil.DisplayMember = "Aciklama";
            cmbil.ValueMember = "ID";
            cmbil.DataSource = db.Iller.ToList();
            cmbil.Text = "Seçiniz";

            cmbyonetici.DataSource = db.Personeller.Where(x => x.YoneticiMi == true).ToList();
            cmbyonetici.DisplayMember = "Ad";
            cmbyonetici.ValueMember = "PersonelID";
            cmbyonetici.Text = "Seçiniz";

        }

        private void cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbilce.DisplayMember = "Aciklama";
                cmbilce.ValueMember = "ID";
                cmbilce.DataSource = db.Ilceler.Where(x => x.IlID == (int)cmbil.SelectedValue).ToList();

            }
            catch (Exception)
            {
            }
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Personel p = new Personel();
            p.Ad = txtad.Text;
            p.Soyad = txtsoyad.Text;
            p.DogumTarihi = dateTimePicker1.Value.Date;
            p.Maas = Convert.ToDecimal(txtmaas.Text);
            p.Email = txtmail.Text;
            p.Adres = txtadres.Text;
            p.EgitimID = (int)cmbegitim.SelectedValue;
            p.UnvanID = (int)cmbunvan.SelectedValue;
            p.IlceID = (int)cmbilce.SelectedValue;

            try
            {
                p.YoneticiID = (int)cmbyonetici.SelectedValue;
            }
            catch (Exception)
            {
                p.YoneticiID = null;
            }
            p.YoneticiMi = chcyoneticimi.Checked;
            db.Personeller.Add(p);
            db.SaveChanges();
            datadoldur();
            combodoldur();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            Personel p = db.Personeller.Find(secilenID);
            db.Personeller.Remove(p);
            db.SaveChanges();
            datadoldur();
            combodoldur();
        }

        private void btnguncel_Click(object sender, EventArgs e)
        {
            Personel p = db.Personeller.Find(secilenID);
            p.Ad = txtad.Text;
            p.Soyad = txtsoyad.Text;
            p.Maas = Convert.ToDecimal(txtmaas.Text);
            p.Email = txtmail.Text;
            p.Adres = txtadres.Text;
            p.UnvanID = (int)cmbunvan.SelectedValue;
            p.EgitimID = (int)cmbegitim.SelectedValue;
            p.IlceID = (int)cmbilce.SelectedValue;
            p.DogumTarihi = dateTimePicker1.Value;
            p.YoneticiID = (int)cmbyonetici.SelectedValue;
            p.ilce.IlID=(int)cmbil.SelectedValue;

            db.SaveChanges();
            datadoldur();
            combodoldur();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            Personel p = db.Personeller.Find(secilenID);

            txtad.Text = p.Ad;
            txtsoyad.Text = p.Soyad;
            txtmaas.Text = p.Maas.ToString();
            txtmail.Text = p.Email;
            txtadres.Text = p.Adres;
            cmbunvan.SelectedValue = p.UnvanID;
            cmbegitim.SelectedValue = p.EgitimID;
            cmbilce.SelectedValue = p.IlceID;
            cmbil.SelectedValue = p.ilce.IlID;
            chcyoneticimi.Checked = p.YoneticiMi;

        }
    }
}
