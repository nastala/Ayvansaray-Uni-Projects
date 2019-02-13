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
    public partial class FormIlce : FormTanitim
    {
        public FormIlce()
        {
            InitializeComponent();
        }
        int secilenID;
        private void FormIlce_Load(object sender, EventArgs e)
        {
            Doldur();
            ComboDoldur();
        }

        private void ComboDoldur()
        {
            comboBox1.DataSource = db.Iller.Select(x => new
            {
                x.Aciklama,
                x.ID,

            }).OrderBy(x=>x.Aciklama).ToList();
            comboBox1.DisplayMember = "Aciklama";
            comboBox1.ValueMember = "ID";
        }

        private void Doldur()
        {
            dataGridView1.DataSource = db.Ilceler.Select(x => new
            {
                ilceID = x.ID,
                ilce = x.Aciklama,
                İl = x.il.Aciklama


            }).ToList();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Ilce egt = new Ilce();
            egt.Aciklama = txtaciklama.Text;
            egt.IlID = (int)comboBox1.SelectedValue;
            db.Ilceler.Add(egt);
            db.SaveChanges();
            Doldur();
        }

        private void btnguncel_Click(object sender, EventArgs e)
        {
            db.Ilceler.Find(secilenID).IlID =(int) comboBox1.SelectedValue;
            db.Ilceler.Find(secilenID).Aciklama = txtaciklama.Text;
            db.SaveChanges();
            Doldur();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {

            db.Ilceler.Remove(db.Ilceler.Find(secilenID));
            db.SaveChanges();
            Doldur();

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            secilenID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            txtaciklama.Text = db.Ilceler.Find(secilenID).Aciklama;
            comboBox1.SelectedValue = db.Ilceler.Find(secilenID).IlID;
        }
    }
}
