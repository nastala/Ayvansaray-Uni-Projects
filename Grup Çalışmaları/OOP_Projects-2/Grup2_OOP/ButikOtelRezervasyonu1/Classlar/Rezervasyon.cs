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

        public Rezervasyon(int odaSayisi, int gunSayisi)
        {
            _rezervasyonDurumu = new OdaDurumu[odaSayisi, gunSayisi];
            _odaSayisi = odaSayisi;
            _gunSayisi = gunSayisi;
            _currentDate = DateTime.Today;
        }

        public void RastgeleDoldur()
        {
            _rezervasyonDurumu[0, 0] = OdaDurumu.Dolu;
            _rezervasyonDurumu[0, 1] = OdaDurumu.Temizlik;
            _rezervasyonDurumu[0, 5] = OdaDurumu.Dolu;
            _rezervasyonDurumu[0, 6] = OdaDurumu.Temizlik;
            _rezervasyonDurumu[1, 7] = OdaDurumu.Dolu;
            _rezervasyonDurumu[1, 8] = OdaDurumu.Temizlik;
            _rezervasyonDurumu[2, 9] = OdaDurumu.Dolu;
            _rezervasyonDurumu[2, 10] = OdaDurumu.Temizlik;
            _rezervasyonDurumu[5, 15] = OdaDurumu.Dolu;
            _rezervasyonDurumu[5, 16] = OdaDurumu.Temizlik;
            _rezervasyonDurumu[8, 20] = OdaDurumu.Dolu;
            _rezervasyonDurumu[8, 21] = OdaDurumu.Temizlik;
            _rezervasyonDurumu[0, 27] = OdaDurumu.Dolu;
            _rezervasyonDurumu[0, 28] = OdaDurumu.Temizlik;
            _rezervasyonDurumu[9, 29] = OdaDurumu.Dolu;
            _rezervasyonDurumu[4, 0] = OdaDurumu.Temizlik;
            _rezervasyonDurumu[5, 1] = OdaDurumu.Dolu;
            _rezervasyonDurumu[5, 2] = OdaDurumu.Temizlik;
        }

        public string[] bugunkuBosOdalar()
        {
            List<OdaDurumu> bosOdalar = new List<OdaDurumu>();
            for(int i = 0; i < _odaSayisi; i++)
            {
                OdaDurumu oda = _rezervasyonDurumu[i, 0];
                if (oda == OdaDurumu.Bos)
                    bosOdalar.Add(oda);
            }
            return null;
        }
    }
}
