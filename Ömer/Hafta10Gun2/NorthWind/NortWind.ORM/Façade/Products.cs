using NorthWind.ORM;
using System.Data;

namespace NorthWind.ORM.Façade
{
    public class Products
    {
        public static DataTable Select => EntityObject.SelectQuery("ListProducts");
    }
}
