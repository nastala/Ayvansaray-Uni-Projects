using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhasebe.Entities
{
    public class Invoice : DatabaseObject
    {
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        [Required]
        [Display(Name ="Müşteri")]
        public virtual Customer Customer { get; set; }
        [Required]
        [Display(Name ="İrsaliye No")]
        public string WaybillNumber { get; set; }
        [Required]
        [Display(Name ="Ödeme Tarihi")]
        public DateTime PaymentDate { get; set; }
        [Required]
        [Display(Name ="Fatura Tarihi")]
        public DateTime InvoiceDate { get; set; }
        //[Required]
        //[Display(Name ="Fatura Detayları")]
        //public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }

        public Invoice()
        {
            InvoiceDate = DateTime.Now;
        }

        public override string ToString()
        {
            return InvoiceDate.ToLongDateString();
        }
    }
}
