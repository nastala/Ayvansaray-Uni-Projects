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
    public partial class FormIl : FormTanitim
    {
        public FormIl()
        {
            InitializeComponent();
            
        }
        int secilenID;
        private void Doldur()
        {
            dataGridView1.DataSource = db.Iller.Select(x => new
            {
                x.ID,
                x.Aciklama
            }).ToList();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            secilenID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            txtaciklama.Text = db.Iller.Find(secilenID).Aciklama;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Il il = new Il();
            il.Aciklama = txtaciklama.Text;
            db.Iller.Add(il);
            db.SaveChanges();
            Doldur();
        }

        private void btnguncel_Click(object sender, EventArgs e)
        {
            db.Iller.Find(secilenID).Aciklama = txtaciklama.Text;
            db.SaveChanges();
            Doldur();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            db.Iller.Remove(db.Iller.Find(secilenID));
            db.SaveChanges();
            Doldur();
        }

        private void FormIl_Load(object sender, EventArgs e)
        {
            Doldur();
        }
    }
}
