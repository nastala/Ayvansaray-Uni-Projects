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
    public partial class FormUnvan : FormTanitim
    {
        public FormUnvan()
        {
            InitializeComponent();
            
        }
        int secilenID;
        private void Doldur()
        {
            dataGridView1.DataSource = db.Unvanlar.Select(x => new
            {
                x.ID,
                x.Aciklama
            }).ToList();
            //dataGridView1.DataSource = db.Set<Unvan>().Select(x => new
            //{
            //    x.ID,
            //    x.Aciklama
            //}).ToList();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Unvan unv = new Unvan();
            unv.Aciklama = txtaciklama.Text;
            db.Unvanlar.Add(unv);
        //    db.Set<Unvan>().Add(unv);
            db.SaveChanges();
            Doldur();
        }

        private void btnguncel_Click(object sender, EventArgs e)
        {
            db.Unvanlar.Find(secilenID).Aciklama = txtaciklama.Text;
           // db.Set<Unvan>().Find(secilenID);
            db.SaveChanges();
            Doldur();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            secilenID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            txtaciklama.Text = db.Unvanlar.Find(secilenID).Aciklama;
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            Unvan unv = db.Unvanlar.Find(secilenID);
            db.Unvanlar.Remove(unv);
         //   db.Set<Unvan>().Remove(unv);
            db.SaveChanges();
            Doldur();
        }

        private void FormUnvan_Load(object sender, EventArgs e)
        {
            Doldur();
        }

    }
}
