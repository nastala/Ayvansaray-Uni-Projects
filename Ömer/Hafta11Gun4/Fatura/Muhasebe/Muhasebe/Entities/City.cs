using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhasebe.Entities
{
    public class City : DatabaseObject
    {
        [Required]
        [Display(Name = "Şehir Adı")]
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
