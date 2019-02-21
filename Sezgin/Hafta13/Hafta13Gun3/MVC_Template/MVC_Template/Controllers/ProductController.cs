using MVC_Template.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Template.Controllers
{
    public class ProductController : Controller
    {
        private NorthwindModel _model = new NorthwindModel();

        // GET: Product
        public ActionResult Index()
        {
            return View(_model.Products.ToList());
        }

        public ActionResult Details(int? productID)
        {
            if (productID == null)
                return RedirectToAction("Index");

            Product product = _model.Products.Find(productID);

            if (product == null)
                return HttpNotFound();

            ViewBag.SupplierID = new SelectList(_model.Suppliers, "SupplierID", "ContactName");
            ViewBag.CategoryID = new SelectList(_model.Categories, "CategoryID", "CategoryName");
            return View(product);
        }

        [HttpPost]
        public ActionResult Details([Bind(Include = "ProductID, ProductName, UnitPrice, UnitsInStock, CategoryID, SupplierID, UnitsOnOrder, ReorderLevel, QuantityPerUnit, Discontinued")] Product product)
        {
            if (ModelState.IsValid)
            {
                _model.Entry(product).State = EntityState.Modified;
                _model.SaveChanges();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Details", new { productID = product.ProductID });
        }

        public ActionResult Create()
        {
            ViewBag.SupplierID = new SelectList(_model.Suppliers, "SupplierID", "CompanyName");
            ViewBag.CategoryID = new SelectList(_model.Categories, "CategoryID", "CategoryName");
            return View(new Product());
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "ProductName, UnitPrice, UnitsInStock, CategoryID, SupplierID, UnitsOnOrder, ReorderLevel, QuantityPerUnit, Discontinued")] Product product)
        {
            if (ModelState.IsValid)
            {
                _model.Products.Add(product);
                _model.SaveChanges();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Create");
        }

        public ActionResult Delete(int? productID)
        {
            if (productID == null)
                return RedirectToAction("Index");

            Product product = _model.Products.Find(productID);

            if (product == null)
                return RedirectToAction("Index");

            _model.Products.Remove(product);
            _model.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}