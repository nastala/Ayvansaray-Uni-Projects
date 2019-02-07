using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhasebe.Entities
{
    public class Customer : DatabaseObject
    {
        [Required]
        [Display(Name = "Müşteri Ünvanı")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Müşteri Şehri")]
        public virtual City City { get; set; }
        [Display(Name = "Müşteri İlçesi")]
        public virtual District District { get; set; }
        [Required]
        [Display(Name = "Müşteri Adresi")]
        public string Address { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }

        public Customer()
        {
            Invoices = new HashSet<Invoice>();
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
