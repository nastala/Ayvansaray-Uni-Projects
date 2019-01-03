using Grup3_OOP.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grup3_OOP.Classlar
{
    class Grup3_FakeData
    {
        private List<string> _adlar = new List<string>();
        private List<string> _soyadlar = new List<string>();
        private List<string> _kitaplar = new List<string>();
        private List<Karma> _karmalar = new List<Karma>();
        private KutuphaneDataContext _db = new KutuphaneDataContext();
        
        public Grup3_FakeData()
        {
            _adlar = AdlariGetir();
            _soyadlar = SoyadlariGetir();
            _kitaplar = KitaplariGetir();
        }

        public List<string> AdlariGetir()
        {
            var adlar = _db.ogrencis.Select(ogrenci => ogrenci.ograd).Distinct();
            foreach (string ad in adlar)
                _adlar.Add(ad);

            return _adlar;
        }

        public List<string> SoyadlariGetir()
        {
            var soyadlar = _db.ogrencis.Select(ogrenci => ogrenci.ogrsoyad).Distinct();
            foreach (string soyad in soyadlar)
                _soyadlar.Add(soyad);

            return _soyadlar;
        }

        public List<string> KitaplariGetir()
        {
            var kitaplar = _db.kitaps.Select(kitap => kitap.kitapadi).Distinct();
            foreach (string kitap in kitaplar)
                _kitaplar.Add(kitap);

            return _kitaplar;
        }

        public List<Karma> KarmalariGetir(int karmaSayisi)
        {
            _karmalar.Clear();
            Random r = new Random();

            for (int i = 0; i < karmaSayisi; i++)
            {
                int rAd = r.Next(0, _adlar.Count);
                int rSoyad = r.Next(0, _soyadlar.Count);
                int rKitap = r.Next(0, _kitaplar.Count);

                Karma karma = new Karma();
                karma.ID = i;
                karma.YazarAd = _adlar[rAd];
                karma.YazarSoyad = _soyadlar[rSoyad];
                karma.KitapAdi = _kitaplar[rKitap];
                _karmalar.Add(karma);
            }

            return _karmalar;
        }

        public class Karma
        {
            public int ID { get; set; }
            public string YazarAd { get; set; }
            public string YazarSoyad { get; set; }
            public string KitapAdi { get; set; }
        }
    }
}
