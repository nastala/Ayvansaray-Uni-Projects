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

        public FormFaturaGoruntule()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            _db = new FaturaContext();

            cbMusteriSehir.DisplayMember = "Aciklama";
            cbMusteriSehir.ValueMember = "IlId";
            cbMusteriSehir.DataSource = _db.Iller.ToList();
        }

        private void cbMusteriSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMusteriSehir.SelectedIndex == -1)
                return;

            cbMusteriIlce.DisplayMember = "Aciklama";
            cbMusteriIlce.ValueMember = "IlceId";
            cbMusteriIlce.DataSource = _db.Ilceler.Where(ilce => ilce.IlId == Convert.ToInt32(cbMusteriSehir.SelectedValue));
        }
    }
}
