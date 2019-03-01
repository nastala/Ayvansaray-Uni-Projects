using MVC_Template.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Template.Controllers
{
    [Authorize]
    public class TedarikciController : Controller
    {
        NorthwindContext ctx = new NorthwindContext();
        // GET: Tedarikci
        public ActionResult Index()
        {
            List<Supplier> ktg = ctx.Suppliers.ToList();
            return View(ktg);
        }

        // Bu methodun içinde oluşan hata Ajax'ı etkilemez. Ajax için success Ajax'ın doğru bir şekilde action'a ulaşmış olmasıyla ilgilidir. Bu methodda veritabanındaki ilişkilerden dolayı kayıt silinemez ve benzeri hatalar Ajax'ı ilgilendirmez. Bu yüzden bu method içinde oluşan hatalarla ilgili Ajax tarafına bilgi göndermeliyiz. 
        [HttpPost]
        public string TedarikciSil(int id)
        {
            try
            {
                Supplier s = ctx.Suppliers.Find(id);
                ctx.Suppliers.Remove(s);
                ctx.SaveChanges();

                return "OK";
            }
            catch(Exception)
            {
                return "ERROR";
            }
        }
        public ActionResult TedarikciEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TedarikciEkle([Bind(Include = "SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone")] Supplier supplier)
        {
            if (ModelState.IsValid)
            {
                ctx.Suppliers.Add(supplier);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }

            return RedirectToAction("TedarikciEkle");
        }

        public ActionResult Guncelle(int? id)
        {
            if (id == null)
                return RedirectToAction("Index");

            Supplier supplier = ctx.Suppliers.Find(id);

            if (supplier == null)
                return HttpNotFound();

            return View(supplier);
        }

        [HttpPost]
        public ActionResult Guncelle([Bind(Include = "SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone")] Supplier supplier)
        {
            if (ModelState.IsValid)
            {
                ctx.Entry(supplier).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Guncelle", new { id = supplier.SupplierID });
        }
    }
}