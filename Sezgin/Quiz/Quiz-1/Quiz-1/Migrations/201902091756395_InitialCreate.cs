namespace Quiz_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Buses",
                c => new
                    {
                        BusID = c.Int(nullable: false, identity: true),
                        SeatCount = c.Int(nullable: false),
                        Name = c.String(),
                        Plate = c.String(),
                        Image = c.Binary(),
                        Driver_DriverID = c.Int(),
                    })
                .PrimaryKey(t => t.BusID)
                .ForeignKey("dbo.Drivers", t => t.Driver_DriverID)
                .Index(t => t.Driver_DriverID);
            
            CreateTable(
                "dbo.Drivers",
                c => new
                    {
                        DriverID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.DriverID);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityID = c.Int(nullable: false, identity: true),
                        PlateNumber = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CityID)
                .Index(t => t.PlateNumber, unique: true);
            
            CreateTable(
                "dbo.Passengers",
                c => new
                    {
                        PassengerID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        IdentityNumber = c.String(),
                        Gender = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PassengerID);
            
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
            
            CreateTable(
                "dbo.Trips",
                c => new
                    {
                        TripID = c.Int(nullable: false, identity: true),
                        IsLeft = c.Boolean(nullable: false),
                        ArrivalCity_CityID = c.Int(),
                        Bus_BusID = c.Int(),
                        DepartureCity_CityID = c.Int(),
                    })
                .PrimaryKey(t => t.TripID)
                .ForeignKey("dbo.Cities", t => t.ArrivalCity_CityID)
                .ForeignKey("dbo.Buses", t => t.Bus_BusID)
                .ForeignKey("dbo.Cities", t => t.DepartureCity_CityID)
                .Index(t => t.ArrivalCity_CityID)
                .Index(t => t.Bus_BusID)
                .Index(t => t.DepartureCity_CityID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TripDetails", "Trip_TripID", "dbo.Trips");
            DropForeignKey("dbo.Trips", "DepartureCity_CityID", "dbo.Cities");
            DropForeignKey("dbo.Trips", "Bus_BusID", "dbo.Buses");
            DropForeignKey("dbo.Trips", "ArrivalCity_CityID", "dbo.Cities");
            DropForeignKey("dbo.TripDetails", "Passenger_PassengerID", "dbo.Passengers");
            DropForeignKey("dbo.Buses", "Driver_DriverID", "dbo.Drivers");
            DropIndex("dbo.Trips", new[] { "DepartureCity_CityID" });
            DropIndex("dbo.Trips", new[] { "Bus_BusID" });
            DropIndex("dbo.Trips", new[] { "ArrivalCity_CityID" });
            DropIndex("dbo.TripDetails", new[] { "Trip_TripID" });
            DropIndex("dbo.TripDetails", new[] { "Passenger_PassengerID" });
            DropIndex("dbo.Cities", new[] { "PlateNumber" });
            DropIndex("dbo.Buses", new[] { "Driver_DriverID" });
            DropTable("dbo.Trips");
            DropTable("dbo.TripDetails");
            DropTable("dbo.Passengers");
            DropTable("dbo.Cities");
            DropTable("dbo.Drivers");
            DropTable("dbo.Buses");
        }
    }
}
