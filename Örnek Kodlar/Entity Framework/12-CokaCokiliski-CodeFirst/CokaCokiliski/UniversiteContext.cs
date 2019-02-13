namespace CokaCokiliski
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;

    public class UniversiteContext : DbContext
    {

        public UniversiteContext()
            : base("Baglanti")
        {
        }
 

        public virtual DbSet<Ogrenci> Ogrenci { get; set; }
        public virtual DbSet<Egitmen> Egitmen { get; set; }
    }

    [Table("Egitmenler")]
    public class Egitmen
    {
        public Egitmen()
        {
            this.Ogrenci = new HashSet<Ogrenci>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public virtual ICollection<Ogrenci> Ogrenci { get; set; }
    }
    [Table("Ogrenciler")]
    public class Ogrenci
    {
        public Ogrenci()
        {
            this.Egitmen = new HashSet<Egitmen>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public virtual ICollection<Egitmen> Egitmen { get; set; }
    }
}