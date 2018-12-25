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
            InitializeComponent();  //sayfaya eklediğimiz tüm kontrolleri içinde tutuyor
        }

        private void btnCoolaps_Click(object sender, EventArgs e)
        {
            switch (splitContainer1.Panel2Collapsed)
            {
                case true:
                    splitContainer1.Panel2Collapsed = false;
                    btnCoolaps.Text = "GİZLE";
                    btnCoolaps.BackColor = Color.Maroon;
                    break;
                case false:
                    splitContainer1.Panel2Collapsed = true;
                    btnCoolaps.Text = "GÖSTER";
                    btnCoolaps.BackColor = Color.Green;
                    break;

            }
        }

        private void frmFirmaGiris_Load(object sender, EventArgs e)
        {
            Temizle();
            Combo();
        }
        void Temizle()
        {
            foreach (Control ct in splitContainer1.Panel1.Controls)
            {
                if (ct is TextBox || ct is ComboBox)
                    ct.Text = "";
            }
            _edit = false;
            txtFirmaNo.Text = _n.FirNo();
        }
        void Combo()
        {
            cbFirmaTip.Items.Clear();
            cbFirmaTip.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection veri = new AutoCompleteStringCollection();
            var ct = _db.bgFirmaTipis.Select(x => x.Ftipi).Distinct();
            foreach (string ftip in ct)
            {
                veri.Add(ftip);
                cbFirmaTip.Items.Add(ftip);
            }
            cbFirmaTip.AutoCompleteCustomSource = veri;
        }
        void YeniKaydet()
        {
            bgFirmaKayit fk = new bgFirmaKayit()
            {
                Fadi = txtFirmaAdi.Text,
                Fno = int.Parse(txtFirmaNo.Text),
                Fadres = txtAdres.Text,
                Ffaks = txtFaks.Text,
                Ftel1 = txtTel1.Text,
                Ftel2 = txtTel2.Text,
                Femail = txtEposta.Text,
                Fvd = txtVd.Text,
                Fvno = txtVTc.Text,
                Fyetkili = txtYetkili.Text,
                Fweb = txtWeb.Text,
                Fdepartman = txtDepartman.Text,
                Ftipi = _db.bgFirmaTipis.First(x => x.Ftipi == cbFirmaTip.Text).Id,
                saveDate = DateTime.Now,
                saveUser = -1
            };
            _db.bgFirmaKayits.InsertOnSubmit(fk);
            _db.SubmitChanges();
            _m.YeniKayit("Kayıt Başarıyla oluşturuldu.");
            Temizle();
            Close(); //formu kapat
            _f.FrmGir(); //formu yeniden aç

        }
        protected override void OnLoad(EventArgs e)
        {
            var btnfrm = new Button();
            btnfrm.Size = new Size(25,txtFirmaNo.ClientSize.Height+2);
            btnfrm.Location = new Point(txtFirmaNo.ClientSize.Width - btnfrm.Width,-1);
            btnfrm.Cursor = Cursors.Default;
            btnfrm.Image = FirmaKayit.Properties.Resources.Koala;
            txtFirmaNo.Controls.Add(btnfrm);
            SendMessage(txtFirmaNo.Handle, 0xd3, (IntPtr)2, (IntPtr)(btnfrm.Width << 16));
            btnfrm.Anchor=(AnchorStyles.Top | AnchorStyles.Right);
            base.OnLoad(e);
            btnfrm.Click += btnfrm_Click;
        }
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
        private void btnfrm_Click(object sender, EventArgs e)
        {
            int id = _f.FrmListe(true);
            if (id > 0)
            {
                Ac(id);
            }
            AnaSayfa.Aktarma = -1;
        }
        void Ac(int id)
        {
            try
            {
                _edit = true;
                bgFirmaKayit fk = _db.bgFirmaKayits.First(z=>z.Fno == id);
                txtAdres.Text = fk.Fadres;
                txtDepartman.Text = fk.Fdepartman;
                txtEposta.Text = fk.Femail;
                txtFaks.Text = fk.Ffaks;
                txtFirmaAdi.Text = fk.Fadi;
                txtFirmaNo.Text = fk.Fno.ToString().PadLeft(7, '0');
                txtTel1.Text = fk.Ftel1;
                txtTel2.Text = fk.Ftel2;
                txtVd.Text = fk.Fvd;
                txtVTc.Text = fk.Fvno;
                txtWeb.Text = fk.Fweb;
                txtYetkili.Text = fk.Fyetkili;
                cbFirmaTip.Text = fk.bgFirmaTipi.Ftipi;
            }
            catch (Exception e)
            {
                _m.Hata(e);
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //YeniKaydet();
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

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
        void Guncelle()
        {
            bgFirmaKayit fk = _db.bgFirmaKayits.First(x => x.Fno == int.Parse(txtFirmaNo.Text));
            fk.Fadi = txtFirmaAdi.Text;
            fk.Fadres = txtAdres.Text;
            fk.Fdepartman = txtDepartman.Text;
            fk.Femail = txtEposta.Text;
            fk.Ffaks = txtFaks.Text;
            fk.Fno =int.Parse( txtFirmaNo.Text);
            fk.Ftel1 = txtTel1.Text;
            fk.Ftel2 = txtTel2.Text;
            fk.Ftipi = _db.bgFirmaTipis.First(x => x.Ftipi == cbFirmaTip.Text).Id;
            fk.Fvd = txtVd.Text;
            fk.Fvno = txtVTc.Text;
            fk.Fweb = txtWeb.Text;
            fk.Fyetkili = txtYetkili.Text;
            fk.updateDate = DateTime.Now;
            fk.updateUser = -1;

            _db.SubmitChanges();
            _m.Guncelle(true);
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
    }
}
