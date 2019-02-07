using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhasebe.Entities
{
    public class District : DatabaseObject
    {
        [Required]
        [Display(Name ="İlçe Adı")]
        public string Name { get; set; }
        [Required]
        [Display(Name ="Şehir")]
        public virtual City City { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
