using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CokaCokiliski
{
    public class DbSingleton
    {
      private static  UniversiteContext db;

        public static  UniversiteContext  GetInstance()
        {
            if (db == null)
            {
                db = new UniversiteContext();
               
            }
            return db;
        }
    }
}
