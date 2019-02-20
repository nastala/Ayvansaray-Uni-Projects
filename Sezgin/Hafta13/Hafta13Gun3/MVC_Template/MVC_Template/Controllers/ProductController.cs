using MVC_Template.Models;
using System;
using System.Collections.Generic;
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

        public ActionResult Details(int productID)
        {
            Product product = _model.Products.Find(productID);
            ViewBag.SupplierID = new SelectList(_model.Suppliers, "SupplierID", "CompanyName");
            return View(product);
        }
    }
}