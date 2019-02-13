namespace IK_Uygulama_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ilk : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Egitim",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Aciklama = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Personel",
                c => new
                    {
                        PersonelID = c.Int(nullable: false, identity: true),
                        Ad = c.String(nullable: false, maxLength: 30),
                        Soyad = c.String(nullable: false, maxLength: 30),
                        Email = c.String(nullable: false, maxLength: 30),
                        Adres = c.String(nullable: false, maxLength: 200),
                        EgitimID = c.Int(nullable: false),
                        UnvanID = c.Int(nullable: false),
                        IlceID = c.Int(nullable: false),
                        YoneticiID = c.Int(),
                        YoneticiMi = c.Boolean(nullable: false),
                        Maas = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DogumTarihi = c.DateTime(nullable: false),
                        KayitTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PersonelID)
                .ForeignKey("dbo.Egitim", t => t.EgitimID, cascadeDelete: true)
                .ForeignKey("dbo.Personel", t => t.YoneticiID)
                .ForeignKey("dbo.Ilce", t => t.IlceID, cascadeDelete: true)
                .ForeignKey("dbo.Unvan", t => t.UnvanID, cascadeDelete: true)
                .Index(t => t.EgitimID)
                .Index(t => t.UnvanID)
                .Index(t => t.IlceID)
                .Index(t => t.YoneticiID);
            
            CreateTable(
                "dbo.Ilce",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IlID = c.Int(nullable: false),
                        Aciklama = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Il", t => t.IlID, cascadeDelete: true)
                .Index(t => t.IlID);
            
            CreateTable(
                "dbo.Il",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Aciklama = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Unvan",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Aciklama = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Personel", "UnvanID", "dbo.Unvan");
            DropForeignKey("dbo.Personel", "IlceID", "dbo.Ilce");
            DropForeignKey("dbo.Ilce", "IlID", "dbo.Il");
            DropForeignKey("dbo.Personel", "YoneticiID", "dbo.Personel");
            DropForeignKey("dbo.Personel", "EgitimID", "dbo.Egitim");
            DropIndex("dbo.Ilce", new[] { "IlID" });
            DropIndex("dbo.Personel", new[] { "YoneticiID" });
            DropIndex("dbo.Personel", new[] { "IlceID" });
            DropIndex("dbo.Personel", new[] { "UnvanID" });
            DropIndex("dbo.Personel", new[] { "EgitimID" });
            DropTable("dbo.Unvan");
            DropTable("dbo.Il");
            DropTable("dbo.Ilce");
            DropTable("dbo.Personel");
            DropTable("dbo.Egitim");
        }
    }
}
