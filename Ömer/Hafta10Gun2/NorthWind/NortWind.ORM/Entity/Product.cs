using NortWind.ORM;

namespace NorthWind.ORM.Entity
{
    public class Product : NorthWind.ORM.IEntityObject
    {
        [DontInclude]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int? SupplierID { get; set; }
        public int? CategoryID { get; set; }
        [DontInclude]
        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        [DontInclude]
        public short? UnitsOnOrder { get; set; }
        [DontInclude]
        public short? ReorderLevel { get; set; }
        [DontInclude]
        public bool Discontinued { get; set; }
        [DontInclude]
        public string InsertProcedure => "InsertProduct";
    }
}
