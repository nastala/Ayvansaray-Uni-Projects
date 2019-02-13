namespace IK_Uygulama_CodeFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;

    public class PersonelContext : DbContext
    {

        public PersonelContext()
            : base("Baglanti")
        {
        }
        public virtual DbSet<Personel> Personeller { get; set; }
        public virtual DbSet<Egitim> Egitimler { get; set; }
        public virtual DbSet<Unvan> Unvanlar { get; set; }
        public virtual DbSet<Il> Iller { get; set; }
        public virtual DbSet<Ilce> Ilceler { get; set; }


    }
    [Table("Personel")]
    public class Personel
    {
        [Key]
        public int PersonelID { get; set; }
        [Required(ErrorMessage = "Ad boþ olamaz"), DisplayName("Adý")]
        [StringLength(30)]
        public string Ad { get; set; }
        [Required(ErrorMessage = "Soyad boþ olamaz"), DisplayName("Soyadý"), StringLength(30)]
        public string Soyad { get; set; }
        [Required, DataType(DataType.EmailAddress), StringLength(30)]
        public string Email { get; set; }
        [Required, DataType(DataType.MultilineText), StringLength(200)]
        public string Adres { get; set; }
        public int EgitimID { get; set; }
        public int UnvanID { get; set; }
        public int IlceID { get; set; }
        public int? YoneticiID { get; set; }
        public bool YoneticiMi { get; set; }
        public decimal Maas { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DogumTarihi { get; set; }
        public DateTime KayitTarihi { get; set; }
        [ForeignKey ("YoneticiID")]
        public virtual Personel yonetici { get; set; }
        public virtual ICollection<Personel> Eleman { get; set; }
        public virtual Egitim egitim { get; set; }
        public virtual Unvan unvan { get; set; }
        public virtual Ilce ilce { get; set; }
        
        public Personel()
        {
            this.KayitTarihi = DateTime.Now;
        }
    }
    public   class Tanimlar
    {
        public int ID { get; set; }
        public string Aciklama { get; set; }
    }
    [Table("Egitim")]
    public class Egitim : Tanimlar
    {
        public Egitim()
        {
            this.personel = new HashSet<Personel>();
        }
        public virtual ICollection<Personel> personel { get; set; }

    }
    [Table("Unvan")]
    public class Unvan : Tanimlar
    {
        public Unvan()
        {
            this.personel = new HashSet<Personel>();
        }
        public virtual ICollection<Personel> personel { get; set; }

    }
    [Table("Il")]
    public class Il : Tanimlar
    {
        public Il()
        {
            this.ilce = new HashSet<Ilce>();
        }
        public virtual ICollection<Ilce> ilce { get; set; }
    }
    [Table("Ilce")]
    public class Ilce : Tanimlar
    {
        public Ilce()
        {
            this.personel = new HashSet<Personel>();
        }
        public int IlID { get; set; }
        public virtual Il il { get; set; }
        public virtual ICollection<Personel> personel { get; set; }
    }
}