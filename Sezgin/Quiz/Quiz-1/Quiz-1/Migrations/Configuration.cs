namespace Quiz_1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Quiz_1.Model>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Quiz_1.Model";
        }

        protected override void Seed(Quiz_1.Model context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
