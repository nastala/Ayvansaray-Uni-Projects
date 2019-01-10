using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButikOtelRezervasyonu1.Classlar
{
    class Cadir : Rezervasyon
    {
        private OdaDurumu[,] _bosCadirlar, _cadirRezervasyon;
        private static float[] _gunBazindaDoluluk;
        private static int _sGunSayisi, _sCadirSayisi;
        private static DateTime _sCurrentDate;
        public Cadir()
        {
            _gunSayisi = 30;
            _odaSayisi = 10;
            _cadirRezervasyon = new OdaDurumu[_odaSayisi, _gunSayisi];
            _gunBazindaDoluluk = new float[_gunSayisi];
            _rezervasyonDurumu = _cadirRezervasyon;
            _currentDate = DateTime.Today;
            _sGunSayisi = _gunSayisi;
            _sCadirSayisi = _odaSayisi;
            _sCurrentDate = _currentDate;
            this.RastgeleDoldur();
            GunBazindaDolulukDoldur();
        }

        public void GunBazindaDoluluk()
        {
            TarihCetveliniYazdir();
        }

        public void KucukCadirRezervasyon()
        {
            this.BugunIcinHizliRezervasyon();
        }

        private void BugunIcinBuyukCadirRezervasyon()
        {
            if (_bosOdalar.Count > 1)
            {
                for(int i = 0; i < _bosOdalar.Count - 1; i++)
                {
                    if(_bosOdalar[i] + 1 == _bosOdalar[i + 1])
                    {
                        int oda = _bosOdalar[0];
                        _rezervasyonDurumu[oda, 0] = OdaDurumu.Dolu;
                        _rezervasyonDurumu[oda, 1] = OdaDurumu.Temizlik;
                        GunBazindaDolulukDoldur();
                        Console.WriteLine(string.Format("\n\tOda {0:00} sizin için ayrıldı", oda + 1));
                    }
                }
            }
            else
            {
                Console.WriteLine("\n\tBugün için boş büyük çadır bulunamadı");
            }
        }

        public void BuyukCadirRezervasyon(DateTime dBaslangic, DateTime dBitis)
        {
            #region BugunIcinHizliRezervasyon
            if (dBaslangic == dBitis)
            {
                BugunIcinBuyukCadirRezervasyon();
                return;
            }
            #endregion

            bool check = true;
            if (dBaslangic < _currentDate)
            {
                Console.WriteLine(string.Format("\n\t Başlangıç tarihi {0:dd-MM-yyyy} tarihinden küçük olamaz", _currentDate));
                check = false;
            }

            if (dBitis < dBaslangic)
            {
                Console.WriteLine(string.Format("\n\t Bitiş Tarihi Başlangıç Tarihinden küçük olamaz", _currentDate));
                check = false;
            }

            if (dBitis > _currentDate.AddDays(_gunSayisi))
            {
                Console.WriteLine(string.Format("\n\t Bitiş tarihi {0:dd-MM-yyyy} tarihinden büyük olamaz", _currentDate.AddDays(_gunSayisi)));
                check = false;
            }

            if (check)
            {
                int gunBaslangic = (dBaslangic - _currentDate).Days;
                int gunBitis = (dBitis - _currentDate).Days;
                int oda = TarihAraligindaBosOdayiGetir(gunBaslangic, gunBitis);
                if (oda == -1)
                {
                    Console.Write("\n\t Belirlenen tarih aralığında boş oda bulunamadı");
                    return;
                }
                for (int i = gunBaslangic; i <= gunBitis; i++)
                {
                    _rezervasyonDurumu[oda, i] = OdaDurumu.Dolu;
                }
                if (gunBitis != _gunSayisi - 1)
                    _rezervasyonDurumu[oda, gunBitis + 1] = OdaDurumu.Temizlik;
                BosOdalariDoldur();
                Console.WriteLine(string.Format("\n\t Oda {0:00} sizin için ayrıldı.", oda + 1));
            }
        }

        private static void TarihCetveliniYazdir()
        {
            Console.Write("Günler:    ");
            for (int i = 0; i < _sGunSayisi; i++)
                Console.Write(string.Format(" {0:00}", _sCurrentDate.AddDays(i).Day));
            Console.Write("\nDoluluk %: ");
            for (int i = 0; i < _sGunSayisi; i++)
            {
                Console.Write(string.Format(" {0, 2}", _gunBazindaDoluluk[i]));
            }
        }

        private void GunBazindaDolulukDoldur()
        {
            for(int i = 0; i < _gunSayisi; i++)
            {
                int count = 0;
                for(int j = 0; j < _odaSayisi; j++)
                {
                    if (_rezervasyonDurumu[j, i] != OdaDurumu.Bos)
                        count++;
                }
                _gunBazindaDoluluk[i] = ((float)count / (float)_odaSayisi) * 100;
            }
        }
    }
}
