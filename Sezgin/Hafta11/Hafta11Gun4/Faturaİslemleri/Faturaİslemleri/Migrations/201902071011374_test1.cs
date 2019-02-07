namespace Faturaİslemleri.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FaturaDetay", "GenelToplam", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.FaturaMaster", "FaturaToplam", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.FaturaMaster", "FaturaToplam");
            DropColumn("dbo.FaturaDetay", "GenelToplam");
        }
    }
}
