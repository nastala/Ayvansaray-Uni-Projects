namespace E_Ticaret.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model : DbContext
    {
        public Model()
            : base("name=ModelConnection")
        {
        }

        public virtual DbSet<BrandPicture> BrandPictures { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Picture> Pictures { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductVariant> ProductVariants { get; set; }
        public virtual DbSet<SalesOrderDetail> SalesOrderDetails { get; set; }
        public virtual DbSet<SalesOrder> SalesOrders { get; set; }
        public virtual DbSet<SalesOrderState> SalesOrderStates { get; set; }
        public virtual DbSet<Shipment> Shipments { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<VariantOption> VariantOptions { get; set; }
        public virtual DbSet<VariantType> VariantTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BrandPicture>()
                .HasMany(e => e.Brands)
                .WithOptional(e => e.BrandPicture)
                .HasForeignKey(e => e.PictureID);

            modelBuilder.Entity<Customer>()
                .Property(e => e.UserName)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .Property(e => e.PhoneNumber)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.CustomerAddresses)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.SalesOrders)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.PurchasePrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .Property(e => e.SalePrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Pictures)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductVariants)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.SalesOrderDetails)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesOrderDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrder>()
                .Property(e => e.TotalAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SalesOrder>()
                .HasMany(e => e.SalesOrderDetails)
                .WithRequired(e => e.SalesOrder)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SalesOrderState>()
                .HasMany(e => e.SalesOrders)
                .WithRequired(e => e.SalesOrderState)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Shipment>()
                .Property(e => e.PhoneNumber)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Shipment>()
                .HasMany(e => e.SalesOrders)
                .WithRequired(e => e.Shipment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VariantOption>()
                .HasMany(e => e.ProductVariants)
                .WithRequired(e => e.VariantOption)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VariantType>()
                .Property(e => e.Description)
                .IsFixedLength();

            modelBuilder.Entity<VariantType>()
                .HasMany(e => e.ProductVariants)
                .WithRequired(e => e.VariantType)
                .WillCascadeOnDelete(false);
        }
    }
}
