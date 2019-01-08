using System;
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

        private OdaDurumu[,] _rezervasyonDurumu;
        private List<int> _bosOdalar;
        private int _odaSayisi;
        private int _gunSayisi;
        private DateTime _currentDate;

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

        public void RastgeleDoldur()
        {
            Random r = new Random();
            int rGun, rOda, rDurum;
            int i = 0;
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

        private void BosOdalariDoldur()
        {
            _bosOdalar.Clear();
            for (int i = 0; i < _odaSayisi; i++)
            {
                if (_rezervasyonDurumu[i, 0] == OdaDurumu.Bos && _rezervasyonDurumu[i, 1] == OdaDurumu.Bos)
                    _bosOdalar.Add(i);
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
            }
            #endregion
        }
    }
}
