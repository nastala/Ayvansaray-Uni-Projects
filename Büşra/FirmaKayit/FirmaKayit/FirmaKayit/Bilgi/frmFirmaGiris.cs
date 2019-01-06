using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirmaKayit.Hangar;

namespace FirmaKayit.Bilgi
{
    public partial class frmFirmaGiris : Form
    {
        DbFirmaDataContext _db = new DbFirmaDataContext();
        Formlar _f = new Formlar();
        Mesajlar _m = new Mesajlar();
        Numaralar _n = new Numaralar();

        bool _edit = false;


        public frmFirmaGiris()
        {
            InitializeComponent();
        }

        private void btncollaps_Click(object sender, EventArgs e)
        {
            switch (splitContainer1.Panel2Collapsed)
            {
                case true:
                    splitContainer1.Panel2Collapsed = false;
                    btncollaps.Text = "GİZLE";
                    break;
                case false:
                    splitContainer1.Panel2Collapsed = true;
                    btncollaps.Text = "GÖSTER";
                    break;

            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (_edit && int.Parse(txtFirmaNo.Text) > 0 && _m.Guncelle() == DialogResult.Yes) Guncelle();
            else if (_edit == false)
                YeniKaydet();
            else return;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (_edit && int.Parse(txtFirmaNo.Text) > 0 && _m.Sil() == DialogResult.Yes) Sil();
            else return;
        }

        private void frmFirmaGiris_Load(object sender, EventArgs e)
        {
            Temizle();
            Combo();

        }
        void Combo()
        {
            cbFirmaTip.Items.Clear();
            cbFirmaTip.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection veri = new AutoCompleteStringCollection();
            var ct = _db.bgFirmaTipis.Select(x => x.Ftipi).Distinct();
            foreach(string ftip in ct)
            {
                veri.Add(ftip);
                cbFirmaTip.Items.Add(ftip);
            }
            cbFirmaTip.AutoCompleteCustomSource = veri;
        }
        void YeniKaydet()
        {
            bgFirmaKayit fk = new bgFirmaKayit()
            //parantez içine yazdıklarımıza fk. yazmadan virgüllerle ayırmamızı sağlıyor.
            {
                Fadi = txtFirmaAdi.Text, Fno = int.Parse(txtFirmaNo.Text),
                Fadres = txtAdres.Text,
                Ffax= txtFax.Text,
                Ftel1 = txtTel1.Text,
                Ftel2 = txtTel2.Text,
                Femail = txtEposta.Text,
                Fvd = txtVD.Text,
                Fvno = txtVergiTC.Text,
                Fyetkili =txtYetkili.Text,
                Fweb = txtWeb.Text,
                Fdepertman =txtDepartman.Text,
                Ftipi = _db.bgFirmaTipis.First(x=>x.Ftipi==cbFirmaTip.Text).Id,
                saveDate = DateTime.Now,
                saveUser = -1
            };
            _db.bgFirmaKayits.InsertOnSubmit(fk);
            _db.SubmitChanges();
            _m.YeniKayit("Kayıt başarı ile oluşturuldu");
            Temizle();
            Close();//Formu kapat
            _f.FrmGir();//Formu yeniden aç

            
        }

        void Guncelle()
        {
            bgFirmaKayit fk = _db.bgFirmaKayits.First(x => x.Fno == int.Parse(txtFirmaNo.Text));
            fk.Fadi = txtFirmaAdi.Text;
            fk.Fadres = txtAdres.Text;
            fk.Fdepertman = txtDepartman.Text;
            fk.Femail = txtEposta.Text;
            fk.Ffax = txtFax.Text;
            fk.Fno = int.Parse(txtFirmaNo.Text);
            fk.Ftel1 = txtTel1.Text;
            fk.Ftipi = _db.bgFirmaTipis.First(x => x.Ftipi == cbFirmaTip.Text).Id;
            fk.Fvd = txtVD.Text;
            fk.Fvno = txtVergiTC.Text;
            fk.Fweb = txtWeb.Text;
            fk.Fyetkili = txtYetkili.Text;
            fk.updateDate = DateTime.Now;
            fk.updateUser = -1;
            _db.SubmitChanges();
            _m.Guncelle(true);
            Temizle();
            Close();
            _f.FrmGir();

        }

        void Sil()
        {
            try
            {
                _db.bgFirmaKayits.DeleteOnSubmit(_db.bgFirmaKayits.First(x => x.Fno == int.Parse(txtFirmaNo.Text)));
                _db.SubmitChanges();
                Temizle();
                Close();
                _f.FrmGir();
            }
            catch(Exception e)
            {
                _m.Hata(e);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            //kontroller yüklenmeden o kontrole..
            var btnfrm = new Button();
            btnfrm.Size = new Size(25, txtFirmaNo.ClientSize.Height + 2);
            btnfrm.Location = new Point(txtFirmaNo.ClientSize.Width - btnfrm.Width, -1);
            btnfrm.Cursor = Cursors.Default;
            btnfrm.Image = FirmaKayit.Properties.Resources.Koala;
            txtFirmaNo.Controls.Add(btnfrm);
            SendMessage(txtFirmaNo.Handle, 0xd3, (IntPtr)2, (IntPtr)(btnfrm.Width << 16));
            btnfrm.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            base.OnLoad(e);
            btnfrm.Click += btnfrm_Click;
        }


        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);


        private void btnfrm_Click(object sender, EventArgs e)
        {
            int id = _f.FrmListe(true);
            if(id>0)
            {
                Ac(id);
            }
            AnaSayfa.Aktarma = -1;
        }

        void Ac (int id)
        {
            try
            {
                _edit = true;
                bgFirmaKayit fk = _db.bgFirmaKayits.First(z => z.Fno == id);
                txtAdres.Text = fk.Fadres;
                txtDepartman.Text = fk.Fdepertman;
                txtEposta.Text = fk.Femail;
                txtFax.Text = fk.Ffax;
                txtFirmaAdi.Text = fk.Fadi;
                txtFirmaNo.Text = fk.Fno.ToString().PadLeft(7, '0');
                txtTel1.Text = fk.Ftel1;
                txtTel2.Text = fk.Ftel2;
                txtVD.Text = fk.Fvd;
                txtVergiTC.Text = fk.Fvno;
                txtWeb.Text = fk.Fweb;
                txtYetkili.Text = fk.Fyetkili;
                cbFirmaTip.Text = fk.bgFirmaTipi.Ftipi;
            }
            catch(Exception e)
            {
                _m.Hata(e);
            }
        }

        void Temizle()
        {
            // txtAdres.Text = "";
            foreach (Control ct in splitContainer1.Panel1.Controls)
            {
                if (ct is TextBox || ct is ComboBox)
                    ct.Text = "";
            }
            _edit = false;
            txtFirmaNo.Text = _n.FirNo();
        }
    }
}
