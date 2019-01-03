using Grup3_OOP.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grup3_OOP
{
    public partial class Form1 : Form
    {
        private List<Classlar.IslemOzet> islemOzetler;
        private KutuphaneDataContext _db = new KutuphaneDataContext();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // islemOzetler = new List<Classlar.IslemOzet>();

            // islemOzetleriDoldur();

            // Classlar.Grup3_FakeData fakeData = new Classlar.Grup3_FakeData();
            dataGridView1.DataSource = Classlar.Grup3_FakeData2.GenerateRandomFullNames(10);
        }

        private void islemOzetleriDoldur()
        {
            var query = from islem in _db.islems
                        join ogrenci in _db.ogrencis
                        on islem.ogrno equals ogrenci.ogrno
                        join kitap in _db.kitaps
                        on islem.kitapno equals kitap.kitapno
                        orderby islem.vtarih descending
                        select new { islem, ogrenci, kitap };

            var rows = query.Select(row => row);

            foreach (var row in rows)
            {
                Classlar.IslemOzet islemOzet = new Classlar.IslemOzet();
                islemOzet.IslemNo = row.islem.islemno;
                islemOzet.KitapAdı = row.kitap.kitapadi;
                islemOzet.OgrenciAd = row.ogrenci.ograd;
                islemOzet.OgrenciSoyad = row.ogrenci.ogrsoyad;
                islemOzetler.Add(islemOzet);
            }
        }
    }
}
