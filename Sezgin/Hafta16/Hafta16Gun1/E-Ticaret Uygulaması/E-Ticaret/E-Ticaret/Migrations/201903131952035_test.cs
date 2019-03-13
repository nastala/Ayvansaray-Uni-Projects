namespace E_Ticaret.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BrandPictures",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LargePath = c.String(maxLength: 250),
                        MediumPath = c.String(maxLength: 250),
                        SmallPath = c.String(maxLength: 250),
                        IsDefault = c.Boolean(nullable: false),
                        BrandID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 500),
                        PictureID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.BrandPictures", t => t.PictureID)
                .Index(t => t.PictureID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50, fixedLength: true),
                        PurchasePrice = c.Decimal(nullable: false, storeType: "money"),
                        SalePrice = c.Decimal(nullable: false, storeType: "money"),
                        Description = c.String(maxLength: 500),
                        CreationDate = c.DateTime(nullable: false),
                        ExpirationDate = c.DateTime(),
                        CategoryID = c.Int(),
                        BrandID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Brands", t => t.BrandID)
                .ForeignKey("dbo.Categories", t => t.CategoryID)
                .Index(t => t.CategoryID)
                .Index(t => t.BrandID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 500),
                        PictureID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Pictures", t => t.PictureID)
                .Index(t => t.PictureID);
            
            CreateTable(
                "dbo.Pictures",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LargePath = c.String(maxLength: 250),
                        MediumPath = c.String(maxLength: 250),
                        SmallPath = c.String(maxLength: 250),
                        IsDefault = c.Boolean(nullable: false),
                        SequenceNumber = c.Byte(nullable: false),
                        ProductID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Products", t => t.ProductID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.ProductVariants",
                c => new
                    {
                        ProductID = c.Int(nullable: false),
                        VariantTypeID = c.Int(nullable: false),
                        VariantOptionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProductID, t.VariantTypeID, t.VariantOptionID })
                .ForeignKey("dbo.VariantOptions", t => t.VariantOptionID)
                .ForeignKey("dbo.VariantTypes", t => t.VariantTypeID)
                .ForeignKey("dbo.Products", t => t.ProductID)
                .Index(t => t.ProductID)
                .Index(t => t.VariantTypeID)
                .Index(t => t.VariantOptionID);
            
            CreateTable(
                "dbo.VariantOptions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false, maxLength: 500),
                        VariantTypeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.VariantTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 500, fixedLength: true),
                        CategoryID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SalesOrderDetails",
                c => new
                    {
                        SalesOrderID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        Quantity = c.Int(),
                        UnitPrice = c.Decimal(storeType: "money"),
                        DiscountAmount = c.Double(),
                    })
                .PrimaryKey(t => new { t.SalesOrderID, t.ProductID })
                .ForeignKey("dbo.SalesOrders", t => t.SalesOrderID)
                .ForeignKey("dbo.Products", t => t.ProductID)
                .Index(t => t.SalesOrderID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.SalesOrders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Guid(nullable: false),
                        Date = c.DateTime(nullable: false),
                        TotalAmount = c.Decimal(nullable: false, storeType: "money"),
                        InCart = c.Int(nullable: false),
                        ShipmentID = c.Int(nullable: false),
                        SalesOrderStateID = c.Int(nullable: false),
                        ShipmentTrackingNumber = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.CustomerID)
                .ForeignKey("dbo.SalesOrderStates", t => t.SalesOrderStateID)
                .ForeignKey("dbo.Shipments", t => t.ShipmentID)
                .Index(t => t.CustomerID)
                .Index(t => t.ShipmentID)
                .Index(t => t.SalesOrderStateID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        UserName = c.String(nullable: false, maxLength: 20, fixedLength: true),
                        Email = c.String(maxLength: 50),
                        PhoneNumber = c.String(maxLength: 15, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.CustomerAddresses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Guid(nullable: false),
                        Title = c.String(nullable: false, maxLength: 50),
                        Address = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.CustomerID)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.SalesOrderStates",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Shipments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Address = c.String(maxLength: 500),
                        PhoneNumber = c.String(maxLength: 15, fixedLength: true, unicode: false),
                        WebSite = c.String(maxLength: 50),
                        Email = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.sysdiagrams",
                c => new
                    {
                        diagram_id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 128),
                        principal_id = c.Int(nullable: false),
                        version = c.Int(),
                        definition = c.Binary(),
                    })
                .PrimaryKey(t => t.diagram_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Brands", "PictureID", "dbo.BrandPictures");
            DropForeignKey("dbo.SalesOrderDetails", "ProductID", "dbo.Products");
            DropForeignKey("dbo.SalesOrders", "ShipmentID", "dbo.Shipments");
            DropForeignKey("dbo.SalesOrders", "SalesOrderStateID", "dbo.SalesOrderStates");
            DropForeignKey("dbo.SalesOrderDetails", "SalesOrderID", "dbo.SalesOrders");
            DropForeignKey("dbo.SalesOrders", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.CustomerAddresses", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.ProductVariants", "ProductID", "dbo.Products");
            DropForeignKey("dbo.ProductVariants", "VariantTypeID", "dbo.VariantTypes");
            DropForeignKey("dbo.ProductVariants", "VariantOptionID", "dbo.VariantOptions");
            DropForeignKey("dbo.Pictures", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Products", "CategoryID", "dbo.Categories");
            DropForeignKey("dbo.Categories", "PictureID", "dbo.Pictures");
            DropForeignKey("dbo.Products", "BrandID", "dbo.Brands");
            DropIndex("dbo.CustomerAddresses", new[] { "CustomerID" });
            DropIndex("dbo.SalesOrders", new[] { "SalesOrderStateID" });
            DropIndex("dbo.SalesOrders", new[] { "ShipmentID" });
            DropIndex("dbo.SalesOrders", new[] { "CustomerID" });
            DropIndex("dbo.SalesOrderDetails", new[] { "ProductID" });
            DropIndex("dbo.SalesOrderDetails", new[] { "SalesOrderID" });
            DropIndex("dbo.ProductVariants", new[] { "VariantOptionID" });
            DropIndex("dbo.ProductVariants", new[] { "VariantTypeID" });
            DropIndex("dbo.ProductVariants", new[] { "ProductID" });
            DropIndex("dbo.Pictures", new[] { "ProductID" });
            DropIndex("dbo.Categories", new[] { "PictureID" });
            DropIndex("dbo.Products", new[] { "BrandID" });
            DropIndex("dbo.Products", new[] { "CategoryID" });
            DropIndex("dbo.Brands", new[] { "PictureID" });
            DropTable("dbo.sysdiagrams");
            DropTable("dbo.Shipments");
            DropTable("dbo.SalesOrderStates");
            DropTable("dbo.CustomerAddresses");
            DropTable("dbo.Customers");
            DropTable("dbo.SalesOrders");
            DropTable("dbo.SalesOrderDetails");
            DropTable("dbo.VariantTypes");
            DropTable("dbo.VariantOptions");
            DropTable("dbo.ProductVariants");
            DropTable("dbo.Pictures");
            DropTable("dbo.Categories");
            DropTable("dbo.Products");
            DropTable("dbo.Brands");
            DropTable("dbo.BrandPictures");
        }
    }
}
