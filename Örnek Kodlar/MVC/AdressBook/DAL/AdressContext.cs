using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AdressBook.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AdressBook.DAL
{
    public class AdressContext : DbContext
    {
        public AdressContext(){ }

        public DbSet<Person> People { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}