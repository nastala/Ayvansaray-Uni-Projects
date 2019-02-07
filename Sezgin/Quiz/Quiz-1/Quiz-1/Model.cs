namespace Quiz_1
{
    using Quiz_1.Classes;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Model : DbContext
    {
        public Model()
            : base("name=Model")
        {
        }

        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Trip> Trips { get; set; }
        public virtual DbSet<Bus> Busses { get; set; }
        public virtual DbSet<Passenger> Passengers { get; set; }
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<TripDetail> TripDetails { get; set; }
    }
}