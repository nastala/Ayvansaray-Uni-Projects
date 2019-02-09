namespace Quiz_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TripDetails", "PurchaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Trips", "DepartureTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Trips", "DepartureTime");
            DropColumn("dbo.TripDetails", "PurchaseDate");
        }
    }
}
