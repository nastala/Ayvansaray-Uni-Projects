namespace E_Ticaret.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SalesOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SalesOrder()
        {
            SalesOrderDetails = new HashSet<SalesOrderDetail>();
        }

        public int ID { get; set; }

        public Guid CustomerID { get; set; }

        public DateTime Date { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalAmount { get; set; }

        public int InCart { get; set; }

        public int ShipmentID { get; set; }

        public int SalesOrderStateID { get; set; }

        [StringLength(20)]
        public string ShipmentTrackingNumber { get; set; }

        public virtual Customer Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }

        public virtual SalesOrderState SalesOrderState { get; set; }

        public virtual Shipment Shipment { get; set; }
    }
}
