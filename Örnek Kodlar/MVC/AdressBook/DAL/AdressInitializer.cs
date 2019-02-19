using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AdressBook.Models;

namespace AdressBook.DAL
{
    public class AdressInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<AdressContext>
    {
        protected override void Seed(AdressContext context)
        {
            var adresses = new List<Adress>
            {
                new Adress{ ID = 1, Name = "MyAdressList"},
                new Adress { ID = 2, Name = "MyAdressList"}
            };
            adresses.ForEach(a => context.Adresses.Add(a));
            context.SaveChanges();

            var people = new List<Person>
            {
                new Person{ PersonID = 1, AdressID = 1, FirstName = "Sezgin", LastName = "Yagli", Gender = "M", Company = "Beymen", Email = "sezginyagli@gmail.com", Phone1 = "5386175233" },
                new Person{ PersonID = 2, AdressID = 2, FirstName = "Sezgin", LastName = "Yagli", Gender = "M", Company = "Beymen", Email = "sezgin.games@hotmail.com", Phone1 = "5386175233" }

            };
            people.ForEach(p => context.People.Add(p));
            context.SaveChanges();
        }
    }
}