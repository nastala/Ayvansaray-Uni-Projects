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
                        DriverID = c.Int(),
                    })
                .PrimaryKey(t => t.BusID)
                .Index(t => t.DriverID, unique: true);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        PlateNumber = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.PlateNumber);
            
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
            DropIndex("dbo.Buses", new[] { "DriverID" });
            DropTable("dbo.Trips");
            DropTable("dbo.Passengers");
            DropTable("dbo.Drivers");
            DropTable("dbo.Cities");
            DropTable("dbo.Buses");
        }
    }
}
