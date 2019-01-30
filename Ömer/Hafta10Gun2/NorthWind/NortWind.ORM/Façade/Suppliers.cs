using NorthWind.ORM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NortWind.ORM.Façade
{
    public class Suppliers
    {
        public static DataTable Select => EntityObject.SelectQuery("ListSuppliers");
    }
}
