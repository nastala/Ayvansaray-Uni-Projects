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
             */
            IEnumerable<Category> kategoriler = NorthwindModel.Model.Categories.ToList();
            ViewBag.Kategoriler = kategoriler;

            return View(NorthwindModel.Model.Products.ToList());
        }
    }
}