namespace Faturaİslemleri.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FaturaDetay",
                c => new
                    {
                        FaturaID = c.Int(nullable: false),
                        UrunID = c.Int(nullable: false),
                        Miktar = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ToplamFiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        KDV = c.Decimal(nullable: false, precision: 18, scale: 2),
                        KDVliFiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FaturaToplam = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Aciklama = c.String(),
                    })
                .PrimaryKey(t => new { t.FaturaID, t.UrunID })
                .ForeignKey("dbo.FaturaMaster", t => t.FaturaID, cascadeDelete: true)
                .ForeignKey("dbo.Urun", t => t.UrunID, cascadeDelete: true)
                .Index(t => t.FaturaID)
                .Index(t => t.UrunID);
            
            CreateTable(
                "dbo.FaturaMaster",
                c => new
                    {
                        FaturaID = c.Int(nullable: false, identity: true),
                        MusteriID = c.Int(nullable: false),
                        FaturaTarihi = c.DateTime(nullable: false),
                        IrsaliyeNo = c.Int(nullable: false),
                        OdemeTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.FaturaID)
                .ForeignKey("dbo.Musteri", t => t.MusteriID, cascadeDelete: true)
                .Index(t => t.MusteriID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FaturaMaster", "MusteriID", "dbo.Musteri");
            DropForeignKey("dbo.FaturaDetay", "UrunID", "dbo.Urun");
            DropForeignKey("dbo.FaturaDetay", "FaturaID", "dbo.FaturaMaster");
            DropIndex("dbo.FaturaMaster", new[] { "MusteriID" });
            DropIndex("dbo.FaturaDetay", new[] { "UrunID" });
            DropIndex("dbo.FaturaDetay", new[] { "FaturaID" });
            DropTable("dbo.FaturaMaster");
            DropTable("dbo.FaturaDetay");
        }
    }
}
