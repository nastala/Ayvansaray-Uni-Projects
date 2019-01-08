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
        private int _odaSayisi;
        private int _gunSayisi;
        private DateTime _currentDate;

        public Rezervasyon()
        {
            _odaSayisi = 10;
            _gunSayisi = 30;
            _rezervasyonDurumu = new OdaDurumu[_odaSayisi, _gunSayisi];
            _currentDate = DateTime.Today;
        }

        public Rezervasyon(int odaSayisi, int gunSayisi)
        {
            _rezervasyonDurumu = new OdaDurumu[odaSayisi, gunSayisi];
            _odaSayisi = odaSayisi;
            _gunSayisi = gunSayisi;
            _currentDate = DateTime.Today;
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

        public void BugunkuBosOdalar()
        {
            List<int> bosOdalar = new List<int>();
            for(int i = 0; i < _odaSayisi; i++)
            {
                if (_rezervasyonDurumu[i, 0] == OdaDurumu.Bos && _rezervasyonDurumu[i, 1] == OdaDurumu.Bos)
                    bosOdalar.Add(i + 1);
            }
            if (bosOdalar.Count > 0)
            {
                foreach (int i in bosOdalar)
                    Console.WriteLine(i);
            }
            else
                Console.WriteLine("Boş oda bulunamadı");
        }

        public void BugunIcinHizliRezervasyon()
        {

        }
    }
}
