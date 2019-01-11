using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grup5_OOP.Classlar
{
    class Yat : Rezervasyon
    {
        public Yat()
        {

        }

        public Yat(Random random) : base(random)
        {
        }

        public override string KiralananYerTipi()
        {
            return "yat";
        }
        public override int Fiyat(int gun, bool ciftYer)
        {
            return gun * 1000 * (ciftYer ? 2 : 1);
        }

        public override string UygulamaAdi()
        {
            return "Yat Yeri Rezervasyonu";
        }

        public override bool YanYanaIkiYerBirdenRezervasyonYapabilirMi()
        {
            return true;
        }

        protected override int BugunIcinTekYerlikBosOda()
        {
            for (int i = 0; i < odaSayisi; i++)
            {
                if (rezervasyonDurumu[i, 0] == RezervasyonEnum.Bos)
                    return i;
            }
            return -1;
        }

        protected override int BugunIcinCiftYerlikBosOda()
        {
            for (int i = 0; i < odaSayisi - 1; i++)
            {
                if (rezervasyonDurumu[i, 0] == RezervasyonEnum.Bos && rezervasyonDurumu[i + 1, 0] == RezervasyonEnum.Bos)
                    return i;
            }
            return -1;
        }
    }
}
