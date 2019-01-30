using NortWind.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.ORM.Entity
{
    public class Category : NorthWind.ORM.IEntityObject
    {
        [DontInclude]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        [DontInclude]
        public string InsertProcedure => "InsertCategory";

    }
}
