
using MVCWithAutoView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWithAutoView.Controllers
{
    public class ProducttController : Controller
    {
        NortwindModel _model = new NortwindModel();
        // GET: Product
        public ActionResult Index()
        {
            return View(_model.Products);
        }
        public ActionResult AddProduct(Product product)
        {
            if (product != null)
            {
                _model.Products.Add(product);
            }
            var categories = _model.Categories.ToList();
            ViewBag.CategoryList = categories;

            var suppliers = _model.Suppliers.ToList();
            ViewBag.SupplierList = suppliers;
            return View();
        }

    }
}