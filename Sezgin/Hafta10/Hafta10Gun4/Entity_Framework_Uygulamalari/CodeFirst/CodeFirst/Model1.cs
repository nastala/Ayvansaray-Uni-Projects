namespace CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
    }

    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Teacher
    {
        public int ID { get; set; }
        public List<Student> Students { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}