namespace Quiz_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TripDetails",
                c => new
                    {
                        TripDetailsID = c.Int(nullable: false, identity: true),
                        SeatNumber = c.Int(nullable: false),
                        Passenger_PassengerID = c.Int(),
                        Trip_TripID = c.Int(),
                    })
                .PrimaryKey(t => t.TripDetailsID)
                .ForeignKey("dbo.Passengers", t => t.Passenger_PassengerID)
                .ForeignKey("dbo.Trips", t => t.Trip_TripID)
                .Index(t => t.Passenger_PassengerID)
                .Index(t => t.Trip_TripID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TripDetails", "Trip_TripID", "dbo.Trips");
            DropForeignKey("dbo.TripDetails", "Passenger_PassengerID", "dbo.Passengers");
            DropIndex("dbo.TripDetails", new[] { "Trip_TripID" });
            DropIndex("dbo.TripDetails", new[] { "Passenger_PassengerID" });
            DropTable("dbo.TripDetails");
        }
    }
}
