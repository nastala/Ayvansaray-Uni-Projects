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
    public partial class FormEgitim : FormTanitim
    {


        public FormEgitim()
        {
            InitializeComponent();
        }
        string EntityName = "Egitimler";
        int secilenID;
        private void FormEgitim_Load(object sender, EventArgs e)
        {
            Doldur();

        }

        private void Doldur()
        {
            dataGridView1.DataSource = db.Egitimler.Select(x => new
            {
                x.ID,
                x.Aciklama
            }).ToList();


        }

        private void btnekle_Click(object sender, EventArgs e)
        {

            //db.Set(EntityName.GetType()).Add(EntityName);
            //Type EntityType = Type.GetType(EntityName);
            //Tanimlar t = new Tanimlar();
             
            Egitim egt = new Egitim();
            egt.Aciklama = txtaciklama.Text;
            db.Egitimler.Add(egt);
            db.SaveChanges();
            Doldur();
        }

        private void btnguncel_Click(object sender, EventArgs e)
        {
            db.Egitimler.Find(secilenID).Aciklama = txtaciklama.Text;
            db.SaveChanges();
            Doldur();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            secilenID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            txtaciklama.Text = db.Egitimler.Find(secilenID).Aciklama;
        }

        private void btnsil_Click(object sender, EventArgs e)
        {

            db.Egitimler.Remove(db.Egitimler.Find(secilenID));
            db.SaveChanges();
            Doldur();


        }

    }
}
