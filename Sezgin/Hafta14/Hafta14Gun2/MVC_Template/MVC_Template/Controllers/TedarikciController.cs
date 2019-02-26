using MVC_Template.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Template.Controllers
{
    public class TedarikciController : Controller
    {
        NorthwindContext ctx = new NorthwindContext();
        // GET: Tedarikci
        public ActionResult Index()
        {
            List<Supplier> ktg = ctx.Suppliers.ToList();
            return View(ktg);
        }
        [HttpPost]
        public void TedarikciSil(int id)
        {
            Supplier s = ctx.Suppliers.Find(id);
            ctx.Suppliers.Remove(s);
            ctx.SaveChanges();
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