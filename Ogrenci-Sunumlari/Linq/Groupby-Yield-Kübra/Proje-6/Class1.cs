using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_6
{

    public class AnagramEsitlikKarsilastirici : IEqualityComparer<string>
    {
        public bool Equals(string x, string y)
        {
            return SiraliKarakterleriVer(x) == SiraliKarakterleriVer(y);
        }

        public int GetHashCode(string obj)
        {
            return SiraliKarakterleriVer(obj).GetHashCode();
        }

        private string SiraliKarakterleriVer(string Kelime)
        {
            char[] KelimeninKarakterleri = Kelime.ToCharArray();
            Array.Sort(KelimeninKarakterleri);
            return new string(KelimeninKarakterleri);
        }
    }
}
