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
    public partial class FormYeniFatura : Form
    {
        private FaturaContext _db;
        private Musteri _secilenMusteri;
        private Urun _secilenUrun;
        private HashSet<FaturaDetay> _faturaDetaylari;
        private int _faturaID;
        private FaturaDetay _secilenFaturaDetay;

        public FormYeniFatura()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            _db = new FaturaContext();
            _secilenMusteri = null;
            _secilenUrun = null;
            _faturaDetaylari = new HashSet<FaturaDetay>();
            _secilenFaturaDetay = null;

            dgvYeniFatura.DataSource = _faturaDetaylari;

            FaturaDetay fatura = _db.FaturaDetays.ToList().LastOrDefault();
            _faturaID = fatura == null ? 1 : fatura.FaturaID;
            lblFaturaID.Text = _faturaID.ToString();

            cbUrunAdi.DisplayMember = "UrunAdi";
            cbUrunAdi.ValueMember = "UrunID";
            cbUrunAdi.DataSource = _db.Urunler.ToList();

            cbMusteriSehir.DisplayMember = "Aciklama";
            cbMusteriSehir.ValueMember = "IlId";
            cbMusteriSehir.DataSource = _db.Iller.ToList();
            cbMusteriSehir.Enabled = false;

            cbMusteriIlce.DisplayMember = "Aciklama";
            cbMusteriIlce.ValueMember = "IlceId";
            cbMusteriIlce.DataSource = _db.Ilceler.ToList();
            cbMusteriIlce.Enabled = false;

            cbMusteri.DisplayMember = "MusteriUnvani";
            cbMusteri.ValueMember = "MusteriID";
            cbMusteri.DataSource = _db.Musteriler.ToList();
        }

        private void cbMusteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMusteri.SelectedIndex == -1)
                return;

            _secilenMusteri = (Musteri)cbMusteri.SelectedItem;
            cbMusteriIlce.SelectedItem = _secilenMusteri.ilce;
            cbMusteriSehir.SelectedItem = _secilenMusteri.ilce.il;
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            if (!CheckUrunInputs())
                return;

            decimal kdv = Convert.ToDecimal(txtUrunKDV.Text);
            int adet = (int)nudUrunMiktar.Value;
            decimal toplam = (adet * _secilenUrun.BirimFiyat) + (adet * _secilenUrun.BirimFiyat * kdv / 100);

            FaturaDetay fatura = new FaturaDetay();
            fatura.FaturaID = _faturaID;
            fatura.urun = _secilenUrun;

            FaturaDetay urun = _faturaDetaylari.FirstOrDefault(f => f.UrunID == _secilenUrun.UrunID && f.FaturaID == _faturaID);
            if (urun == null)
            {
                fatura.UrunID = _secilenUrun.UrunID;
                fatura.Miktar = adet;
                fatura.ToplamFiyat = adet * _secilenUrun.BirimFiyat;
                fatura.KDV = kdv;
                fatura.KDVliFiyat = (adet * _secilenUrun.BirimFiyat) + (adet * _secilenUrun.BirimFiyat * kdv / 100);
            }
            else
            {
                fatura = urun;
                fatura.Miktar += adet;
                fatura.ToplamFiyat = fatura.Miktar * _secilenUrun.BirimFiyat;
                fatura.KDV = kdv;
                fatura.KDVliFiyat = fatura.ToplamFiyat + (fatura.ToplamFiyat * kdv / 100);
            }

            _faturaDetaylari.Add(fatura);

            lblFaturaToplam.Text = _faturaDetaylari.Select(f => f.KDVliFiyat).Sum().ToString();

            ClearUrunInputs();
        }

        private void ClearUrunInputs()
        {
            _secilenFaturaDetay = null;
            nudUrunMiktar.Value = 1;
            txtUrunKDV.Text = "";
            dgvYeniFatura.DataSource = _faturaDetaylari.ToList();
        }

        private bool CheckUrunInputs()
        {
            if (cbUrunAdi.SelectedItem == null)
                return false;

            if (_db.Urunler.ToList().FirstOrDefault(u => u.UrunID == (int)cbUrunAdi.SelectedValue) == null)
                return false;

            if (nudUrunMiktar.Value <= 0)
                return false;

            try
            {
                decimal kdv = Convert.ToDecimal(txtUrunKDV.Text);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private bool CheckInputs()
        {
            if (cbMusteri.SelectedItem == null)
                return false;

            if (_db.Musteriler.ToList().FirstOrDefault(m => m.MusteriID == (int)cbMusteri.SelectedValue) == null)
                return false;

            if (string.IsNullOrWhiteSpace(txtIrsaliyeNo.Text))
                return false;

            if (cbUrunAdi.SelectedItem == null)
                return false;

            if (_db.Urunler.ToList().FirstOrDefault(u => u.UrunID == (int)cbUrunAdi.SelectedValue) == null)
                return false;

            if (string.IsNullOrWhiteSpace(txtUrunBirimi.Text))
                return false;

            if (string.IsNullOrWhiteSpace(txtUrunFiyati.Text))
                return false;

            if (string.IsNullOrWhiteSpace(txtUrunKDV.Text))
                return false;

            try
            {
                decimal fiyat = Convert.ToDecimal(txtUrunFiyati.Text);
                int birim = Convert.ToInt32(txtUrunBirimi.Text);
                decimal kdv = Convert.ToDecimal(txtUrunKDV.Text);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void cbUrunAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUrunAdi.SelectedIndex == -1)
                return;

            _secilenUrun = (Urun)cbUrunAdi.SelectedItem;
            txtUrunBirimi.Text = _secilenUrun.Birim.BirimAdi;
            txtUrunFiyati.Text = _secilenUrun.BirimFiyat.ToString();
        }

        private void dgvYeniFatura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || dgvYeniFatura.CurrentRow == null)
                return;

            _secilenFaturaDetay = (FaturaDetay)dgvYeniFatura.CurrentRow.DataBoundItem;
            cbUrunAdi.SelectedItem = _secilenFaturaDetay.urun;
            txtUrunKDV.Text = _secilenFaturaDetay.KDV.ToString();
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            if (_secilenFaturaDetay == null)
                return;

            DialogResult result = MessageBox.Show($"{_secilenFaturaDetay.urun.UrunAdi} adlı ürünü silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                _faturaDetaylari.Remove(_secilenFaturaDetay);
                ClearUrunInputs();
            }
        }
    }
}
