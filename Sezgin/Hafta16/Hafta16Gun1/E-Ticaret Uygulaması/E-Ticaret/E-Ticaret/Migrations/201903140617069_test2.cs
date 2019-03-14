namespace E_Ticaret.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.BrandPictures", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BrandPictures", "Name", c => c.String());
        }
    }
}
