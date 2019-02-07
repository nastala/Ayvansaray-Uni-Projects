using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhasebe.Entities
{
    public class InvoiceDetail : DatabaseObject
    {
        [Required]
        [ForeignKey("Invoice")]
        public int InvoiceId { get; set; }

        [Required]
        [ForeignKey("Product")]
        public int ProductId { get; set; }

        [Display(Name ="Adet")]
        public decimal Amount { get; set; }
        [Display(Name ="Son Toplam")]
        public decimal FinalPrice { get; set; }
        [Display(Name = "KDV")]
        public decimal Tax { get; set; }
        [Display(Name ="KDV'li Fiyat")]
        public decimal TaxIncludedPrice
        {
            get
            {
                return (decimal)Product.UnitPrice * Tax;
            }
        }
        [Display(Name ="Fatura Toplam")]
        public decimal InvoiceFinalPrice
        {
            get
            {
                return TaxIncludedPrice * Amount;
            }
        }
        [Required]
        [Display(Name ="Açıklama")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Ürün")]
        public virtual Product Product { get; set; }
        [Required]
        [Display(Name = "Fatura")]
        public virtual Invoice Invoice { get; set; }
    }
}
