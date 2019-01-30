using NorthWind.ORM;
using System.Data;

namespace NorthWind.ORM.Façade
{
    public class Categories
    {
        public static DataTable Select => EntityObject.SelectQuery("ListCategories");
    }
}
