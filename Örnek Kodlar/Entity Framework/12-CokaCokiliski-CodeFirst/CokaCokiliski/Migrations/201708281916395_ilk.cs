namespace CokaCokiliski.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ilk : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Egitmenler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SurName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ogrenciler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SurName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OgrenciEgitmen",
                c => new
                    {
                        Ogrenci_Id = c.Int(nullable: false),
                        Egitmen_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Ogrenci_Id, t.Egitmen_Id })
                .ForeignKey("dbo.Ogrenciler", t => t.Ogrenci_Id, cascadeDelete: true)
                .ForeignKey("dbo.Egitmenler", t => t.Egitmen_Id, cascadeDelete: true)
                .Index(t => t.Ogrenci_Id)
                .Index(t => t.Egitmen_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OgrenciEgitmen", "Egitmen_Id", "dbo.Egitmenler");
            DropForeignKey("dbo.OgrenciEgitmen", "Ogrenci_Id", "dbo.Ogrenciler");
            DropIndex("dbo.OgrenciEgitmen", new[] { "Egitmen_Id" });
            DropIndex("dbo.OgrenciEgitmen", new[] { "Ogrenci_Id" });
            DropTable("dbo.OgrenciEgitmen");
            DropTable("dbo.Ogrenciler");
            DropTable("dbo.Egitmenler");
        }
    }
}
