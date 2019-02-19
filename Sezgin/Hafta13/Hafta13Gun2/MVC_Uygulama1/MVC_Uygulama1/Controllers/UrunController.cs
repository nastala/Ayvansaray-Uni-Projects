using MVC_Uygulama1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Uygulama1.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun
        public ActionResult Index()
        {
            /*
                Model yöntemi ile gönderiliyorsa view methodu içerisine yazılır ve modelin tanımlaması cshtml'in
                    içerisinde yapılır.
                ViewBag yöntemi ile gönderiliyorsa herhangi bir olmayan dinamik tip tanımlanır ve bu tipin temsil ettiği alana
                    veriler atanabilir.
                GetAction ve PostAction olmak üzere iki tane Action tipi var. Eğer herhangi bir belirtme yapılmazsa varsayılan
                    olarak tanımlanan Action GetAction'dır. 
                GetAction View'e değer gönderir ve View'u çalıştırır.
             */
            IEnumerable<Category> kategoriler = NorthwindModel.Model.Categories.ToList();
            ViewBag.Kategoriler = kategoriler;

            return View(NorthwindModel.Model.Products.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.CategoryID = new SelectList(NorthwindModel.Model.Categories, "CategoryID", "CategoryName");
            ViewBag.SupplierID = new SelectList(NorthwindModel.Model.Suppliers, "SupplierID", "CompanyName");
            //ViewBag.Kategoriler = NorthwindModel.Model.Categories.ToList();
            //ViewBag.Tedarikciler = NorthwindModel.Model.Suppliers.ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductName, UnitPrice, UnitsInStock, CategoryID, SupplierID")] Product urun)
        {
            if (ModelState.IsValid)
            {
                NorthwindModel.Model.Products.Add(urun);
                NorthwindModel.Model.SaveChanges();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Create");
        }
    }
}