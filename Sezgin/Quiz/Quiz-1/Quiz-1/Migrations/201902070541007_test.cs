namespace Quiz_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
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
                .PrimaryKey(t => t.CityID);
            
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
                "dbo.Trips",
                c => new
                    {
                        TripID = c.Int(nullable: false, identity: true),
                        DepartureCityID = c.Int(nullable: false),
                        ArrivalCityID = c.Int(nullable: false),
                        DepartureTime = c.DateTime(nullable: false),
                        TripTime = c.DateTime(nullable: false),
                        BusID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TripID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Buses", "Driver_DriverID", "dbo.Drivers");
            DropIndex("dbo.Buses", new[] { "Driver_DriverID" });
            DropTable("dbo.Trips");
            DropTable("dbo.Passengers");
            DropTable("dbo.Cities");
            DropTable("dbo.Drivers");
            DropTable("dbo.Buses");
        }
    }
}
