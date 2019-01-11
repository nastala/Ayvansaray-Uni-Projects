using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grup5_OOP.Classlar
{
    class ButikOtel : Rezervasyon
    {
        public ButikOtel()
        {

        }

        public ButikOtel(Random random) : base(random)
        {
        }

        public override string KiralananYerTipi()
        {
            return "oda";
        }

        public override int Fiyat(int gun, bool ciftYer)
        {
            return gun * (gun > 5 ? 90 : 100);
        }

        public override string UygulamaAdi()
        {
            return "Butik Otel Rezervasyonu";
        }

        public override bool YanYanaIkiYerBirdenRezervasyonYapabilirMi()
        {
            return false;
        }

        protected override int BugunIcinTekYerlikBosOda()
        {
            for (int i = 0; i < odaSayisi; i++)
            {
                if (rezervasyonDurumu[i, 0] == RezervasyonEnum.Bos && rezervasyonDurumu[i, 1] == RezervasyonEnum.Bos)
                    return i;
            }
            return -1;
        }
    }
}
