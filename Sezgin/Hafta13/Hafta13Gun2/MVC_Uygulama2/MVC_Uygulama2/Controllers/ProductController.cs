using MVC_Uygulama2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Uygulama2.Controllers
{
    public class ProductController : Controller
    {
        NorthwindModel model = new NorthwindModel();

        // GET: Product
        public ActionResult Index()
        {
            return View(model.Products);
        }

        public ActionResult Create()
        {
            ViewBag.SupplierID = new SelectList(model.Suppliers, "SupplierID", "CompanyName");
            ViewBag.CategoryID = new SelectList(model.Categories, "CategoryID", "CategoryName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsInOrder, ReorderLevel, Discontinued, ")] Product product)
        {
            if (ModelState.IsValid)
            {
                model.Products.Add(product);
                model.SaveChanges();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Create");
        }
    }
}