using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta6Gun5_AnaProje.Classlar
{
    abstract class KisiAbstract
    {
        public abstract int MaasHesapla();

        protected virtual int MaasHesapla2()
        {
            return 0;
        }
    }
}
