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

        public int BugunIcinTekYerlikBosOda(int iBaslangic, int iBitis)
        {
            for(int i = 0; i <= odaSayisi; i++)
            {
                bool check = true;
                for (int j = iBaslangic; j < iBitis; j++)
                {
                    if (rezervasyonDurumu[i, j] != RezervasyonEnum.Bos)
                    {
                        check = false;
                        break;
                    }

                    if (check)
                    {
                        if(iBitis < gunSayisi - 1)
                            check = rezervasyonDurumu[i, iBitis + 1] == RezervasyonEnum.Bos;
                    }

                    if (check)
                        return i;
                }
            }

            return -1;
        }
    }
}
