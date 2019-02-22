namespace MVC_Template.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.IO;

    public partial class Category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int CategoryID { get; set; }

        [Required]
        [StringLength(15)]
        public string CategoryName { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        [Column(TypeName = "image")]
        public byte[] Picture { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }

        [NotMapped]
        public string Base64String
        {
            get
            {
                var base64Str = string.Empty;
                var imageSrc = string.Empty;

                if (this.Picture != null)
                {
                    using (var ms = new MemoryStream())
                    {
                        ms.Write(Picture, 78, Picture.Length - 78); // strip out 78 byte OLE header (don't need to do this for normal images)
                        base64Str = Convert.ToBase64String(ms.ToArray());
                        imageSrc = string.Format("data:image;base64,{0}", base64Str);
                    }
                }

                return imageSrc;
            }
        }
    }
}
