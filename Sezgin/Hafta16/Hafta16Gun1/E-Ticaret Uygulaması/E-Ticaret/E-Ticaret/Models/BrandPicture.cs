namespace E_Ticaret.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BrandPicture
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BrandPicture()
        {
            Brands = new HashSet<Brand>();
        }

        public int ID { get; set; }

        public string Name { get; set; }

        [StringLength(250)]
        public string LargePath { get; set; }

        [StringLength(250)]
        public string MediumPath { get; set; }

        [StringLength(250)]
        public string SmallPath { get; set; }

        public bool IsDefault { get; set; }

        public int BrandID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Brand> Brands { get; set; }
    }
}
