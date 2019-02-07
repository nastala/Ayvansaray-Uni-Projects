namespace Quiz_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test1 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Cities", "PlateNumber", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Cities", new[] { "PlateNumber" });
        }
    }
}
