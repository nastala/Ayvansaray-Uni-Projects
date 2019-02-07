namespace Muhasebe
{
    using Muhasebe.Entities;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class AccountingModel : DbContext
    {
        public static AccountingModel DatabaseModel = new AccountingModel();
        public AccountingModel() : base("name=AccountingModel")
        {
        }

        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }
    }
}