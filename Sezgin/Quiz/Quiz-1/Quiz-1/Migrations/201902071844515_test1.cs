namespace Quiz_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Trips", "DepartureTime");
            DropColumn("dbo.Trips", "TripTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Trips", "TripTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Trips", "DepartureTime", c => c.DateTime(nullable: false));
        }
    }
}
