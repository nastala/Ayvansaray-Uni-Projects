using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhasebe.Entities
{
    public class Product : DatabaseObject
    {
        [Required]
        [Display(Name = "Ürün Adı")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Birim")]
        public virtual Unit Unit { get; set; }
        [Required]
        [Display(Name ="Birim Fiyatı")]
        public double UnitPrice { get; set; }
        [Required]
        [Display(Name = "Ürün Kodu")]
        public string Code { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
