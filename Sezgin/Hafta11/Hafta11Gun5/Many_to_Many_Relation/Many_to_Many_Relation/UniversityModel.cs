namespace Many_to_Many_Relation
{
    using Many_to_Many_Relation.Classes;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class UniversityModel : DbContext
    {
        public UniversityModel()
            : base("name=UniversityModel")
        {
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
    }
}