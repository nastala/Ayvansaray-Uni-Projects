namespace MVC_Template.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.IO;

    public partial class RequestLog
    {
        public RequestLog()
        {
        }

        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string RequestUrl { get; set; }

        [Required]
        public DateTime RequestDate { get; set; }
    }
}
