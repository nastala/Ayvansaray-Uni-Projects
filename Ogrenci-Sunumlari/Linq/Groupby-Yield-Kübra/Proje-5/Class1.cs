using LinqOrnekleri_VeriKaynagi;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_5
{
    public class CinsiyeteGoreBasariKarsilastirici : IEqualityComparer<OgrenciBilgi>
    {

        public bool Equals(OgrenciBilgi x, OgrenciBilgi y)
        {
            if (x.Cinsiyet != y.Cinsiyet && x.Basarili != y.Basarili) return false;

            return true;

        }

        public int GetHashCode(OgrenciBilgi Ogrenci)
        {

            return Ogrenci.Basarili.GetHashCode() + Ogrenci.Cinsiyet.GetHashCode();

        }

    }
}
