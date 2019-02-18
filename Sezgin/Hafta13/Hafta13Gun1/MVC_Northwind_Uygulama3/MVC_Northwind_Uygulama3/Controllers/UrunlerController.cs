using MVC_Northwind_Uygulama3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Northwind_Uygulama3.Controllers
{
    public class UrunlerController : Controller
    {
        private MyDbContext ctx = new MyDbContext();

        // GET: Urunler
        public ActionResult Index()
        {
            // View methodunun arasına bir değişken vermek o değişkeni model yöntemi ile view'e göndermek demektir. Model yöntemiyle bir anda sadece 
            //      bir veri gönderilebilir.
            List<Product> urunler = ctx.Products.ToList();
            return View(urunler);
        }
    }
}