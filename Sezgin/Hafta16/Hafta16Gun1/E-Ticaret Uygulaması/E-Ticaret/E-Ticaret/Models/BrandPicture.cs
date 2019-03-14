namespace E_Ticaret.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BrandPicture
    {
        public int ID { get; set; }

        [StringLength(250)]
        public string LargePath { get; set; }

        [StringLength(250)]
        public string MediumPath { get; set; }

        [StringLength(250)]
        public string SmallPath { get; set; }

        public bool IsDefault { get; set; }
    }
}
