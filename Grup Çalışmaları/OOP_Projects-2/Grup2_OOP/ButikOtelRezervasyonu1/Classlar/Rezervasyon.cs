﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButikOtelRezervasyonu1.Classlar
{
    class Rezervasyon
    {
        public enum OdaDurumu
        {
            Bos,
            Dolu,
            Temizlik
        }

        protected OdaDurumu[,] _rezervasyonDurumu;
        protected List<int> _bosOdalar;
        protected int _odaSayisi;
        protected int _gunSayisi;
        protected DateTime _currentDate;

        public Rezervasyon()
        {
            _odaSayisi = 10;
            _gunSayisi = 30;
            _rezervasyonDurumu = new OdaDurumu[_odaSayisi, _gunSayisi];
            _currentDate = DateTime.Today;
            _bosOdalar = new List<int>();
            RastgeleDoldur();
        }

        public Rezervasyon(int odaSayisi, int gunSayisi)
        {
            _rezervasyonDurumu = new OdaDurumu[odaSayisi, gunSayisi];
            _odaSayisi = odaSayisi;
            _gunSayisi = gunSayisi;
            _currentDate = DateTime.Today;
            _bosOdalar = new List<int>();
        }

        protected void RastgeleDoldur()
        {
            Random r = new Random();
            int rGun, rOda, rDurum;
            int i = 0;

            #region while
            while(i < 50)
            {
                rGun = r.Next(0, _gunSayisi);
                rOda = r.Next(0, _odaSayisi);
                rDurum = r.Next(0, 2);
                if (_rezervasyonDurumu[rOda, rGun] == 0)
                {
                    if(rDurum == 1)
                    {
                        if (rGun != _gunSayisi - 1)
                        {
                            if (_rezervasyonDurumu[rOda, rGun + 1] == OdaDurumu.Bos)
                            {
                                _rezervasyonDurumu[rOda, rGun] = OdaDurumu.Dolu;
                                _rezervasyonDurumu[rOda, rGun + 1] = OdaDurumu.Temizlik;
                                i++;
                            }
                        }
                        else
                        {
                            _rezervasyonDurumu[rOda, rGun] = OdaDurumu.Dolu;
                            i++;
                        }
                    }
                    else
                    {
                        _rezervasyonDurumu[rOda, rGun] = (OdaDurumu)rDurum;
                        i++;
                    }
                }
            }
            #endregion

            BosOdalariDoldur();
        }

        private string OdaDurumuToText(OdaDurumu odaDurumu)
        {
            string text;
            switch (odaDurumu)
            {
                case OdaDurumu.Bos:
                    text = " - ";
                    break;
                case OdaDurumu.Dolu:
                    text = " D ";
                    break;
                case OdaDurumu.Temizlik:
                    text = " x ";
                    break;
                default:
                    text = " - ";
                    break;
            }
            return text;
        }

        protected void BosOdalariDoldur()
        {
            _bosOdalar.Clear();
            for (int i = 0; i < _odaSayisi; i++)
            {
                if (_rezervasyonDurumu[i, 0] == OdaDurumu.Bos && _rezervasyonDurumu[i, 1] == OdaDurumu.Bos)
                    _bosOdalar.Add(i);
            }
        }

        private int TarihAraligindaBosOdayiGetir(int iBaslangic, int iBitis)
        {
            bool check = true;

            for(int i = 0; i < _odaSayisi; i++)
            {
                check = true;
                for(int j = iBaslangic; j <= iBitis; j++)
                {
                    if (_rezervasyonDurumu[i, j] != OdaDurumu.Bos)
                    {
                        check = false;
                        break;
                    }
                }
                if(check && iBitis != _gunSayisi - 1)
                {
                    check = _rezervasyonDurumu[i, iBitis + 1] == OdaDurumu.Bos;
                }
                if (check)
                    return i;
            }

            return -1;
        }

        public void AylikDolulukDurumu()
        {
            Console.WriteLine();
            Console.WriteLine("30 gunluk doluluk durumu");
            Console.Write("      ");
            for (int j = 0; j < _gunSayisi; j++)
            {
                Console.Write(" {0:00}", _currentDate.AddDays(j).Day);
            }
            Console.WriteLine();
            for (int i = 0; i < _odaSayisi; i++)
            {
                Console.Write("Oda {0:00}", i + 1);
                for (int j = 0; j < _gunSayisi; j++)
                {
                    string text = OdaDurumuToText(_rezervasyonDurumu[i, j]);
                    Console.Write(text);
                }
                Console.WriteLine();
            }
        }

        public void BugunkuBosOdalar()
        {
            Console.WriteLine("\n \tBoş odalar:");
            if (_bosOdalar.Count > 0)
            {
                foreach (int i in _bosOdalar)
                    Console.WriteLine(string.Format("Oda {0:00}", i + 1));
            }
            else
                Console.WriteLine("Boş oda bulunamadı");
        }

        public void BugunIcinHizliRezervasyon()
        {
            DateTime dateTime = DateTime.Today;
            IkiTarihArasiHizliRezervasyon(dateTime, dateTime);
        }

        public void IkiTarihArasiHizliRezervasyon(DateTime dBaslangic, DateTime dBitis)
        {
            #region BugunIcinHizliRezervasyon
            if (dBaslangic == dBitis)
            {
                if (_bosOdalar.Count > 0)
                {
                    int oda = _bosOdalar[0];
                    _rezervasyonDurumu[oda, 0] = OdaDurumu.Dolu;
                    _rezervasyonDurumu[oda, 1] = OdaDurumu.Temizlik;
                    BosOdalariDoldur();
                    Console.WriteLine(string.Format("\n\tOda {0:00} sizin için ayrıldı", oda + 1));
                }
                else
                {
                    Console.WriteLine("\n\tBugün için boş oda bulunamadı");
                }
                return;
            }
            #endregion

            bool check = true;
            if (dBaslangic < _currentDate)
            {
                Console.WriteLine(string.Format("\n\t Başlangıç tarihi {0:dd-MM-yyyy} tarihinden küçük olamaz", _currentDate));
                check = false;
            }

            if(dBitis < dBaslangic)
            {
                Console.WriteLine(string.Format("\n\t Bitiş Tarihi Başlangıç Tarihinden küçük olamaz", _currentDate));
                check = false;
            }

            if(dBitis > _currentDate.AddDays(_gunSayisi))
            {
                Console.WriteLine(string.Format("\n\t Bitiş tarihi {0:dd-MM-yyyy} tarihinden büyük olamaz", _currentDate.AddDays(_gunSayisi)));
                check = false;
            }

            if (check)
            {
                int gunBaslangic = (dBaslangic - _currentDate).Days;
                int gunBitis = (dBitis - _currentDate).Days;
                int oda = TarihAraligindaBosOdayiGetir(gunBaslangic, gunBitis);
                if(oda == -1)
                {
                    Console.Write("\n\t Belirlenen tarih aralığında boş oda bulunamadı");
                    return;
                }
                for (int i = gunBaslangic; i <= gunBitis; i++)
                {
                    _rezervasyonDurumu[oda, i] = OdaDurumu.Dolu;
                }
                if(gunBitis != _gunSayisi - 1)
                    _rezervasyonDurumu[oda, gunBitis + 1] = OdaDurumu.Temizlik;
                BosOdalariDoldur();
                Console.WriteLine(string.Format("\n\t Oda {0:00} sizin için ayrıldı.", oda + 1));
            }
        }

        public void GunSonu()
        {
            _currentDate = _currentDate.AddDays(1);
            for(int i = 0; i < _odaSayisi; i++)
            {
                for(int j = 0; j < _gunSayisi - 1; j++)
                {
                    _rezervasyonDurumu[i, j] = _rezervasyonDurumu[i, j + 1];
                    if (j == _gunSayisi - 2)
                    {
                        if (_rezervasyonDurumu[i, j] == OdaDurumu.Dolu)
                            _rezervasyonDurumu[i, j + 1] = OdaDurumu.Temizlik;
                        else
                            _rezervasyonDurumu[i, j + 1] = OdaDurumu.Bos;
                    }
                }
            }

            BosOdalariDoldur();
            Console.WriteLine("\n\t Gün sonu işlemi gerçekleştirildi");
        }
    }
}
