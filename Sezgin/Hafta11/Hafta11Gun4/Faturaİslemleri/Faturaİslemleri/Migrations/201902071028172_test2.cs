namespace Faturaİslemleri.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.FaturaDetay", "FaturaToplam");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FaturaDetay", "FaturaToplam", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
