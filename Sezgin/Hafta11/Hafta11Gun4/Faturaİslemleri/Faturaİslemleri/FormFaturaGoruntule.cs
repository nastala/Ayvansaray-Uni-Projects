using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faturaİslemleri
{
    public partial class FormFaturaGoruntule : Form
    {
        private FaturaContext _db;
        private Musteri _secilenMusteri;

        public FormFaturaGoruntule()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            _db = new FaturaContext();
            _secilenMusteri = null;

            cbMusteriSehir.DisplayMember = "Aciklama";
            cbMusteriSehir.ValueMember = "IlId";
            cbMusteriSehir.DataSource = _db.Iller.ToList();
        }

        private void cbMusteriSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMusteriSehir.SelectedIndex == -1)
                return;

            int ilID = Convert.ToInt32(cbMusteriSehir.SelectedValue);
            cbMusteriIlce.DisplayMember = "Aciklama";
            cbMusteriIlce.ValueMember = "IlceId";
            cbMusteriIlce.DataSource = _db.Ilceler.Where(ilce => ilce.IlId == ilID).ToList();
        }

        private void cbMusteriIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMusteriIlce.SelectedIndex == -1)
                return;

            int ilceID = Convert.ToInt32(cbMusteriIlce.SelectedValue);
            cbMusteri.DisplayMember = "MusteriUnvani";
            cbMusteri.ValueMember = "MusteriID";
            cbMusteri.DataSource = _db.Musteriler.Where(musteri => musteri.IlceID == ilceID).ToList();
        }

        private void cbMusteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMusteri.SelectedIndex == -1)
                return;

            _secilenMusteri = (Musteri)cbMusteri.SelectedItem;
        }
    }
}
