namespace E_Ticaret.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.BrandPictures", "BrandID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BrandPictures", "BrandID", c => c.Int(nullable: false));
        }
    }
}
