using MVC_Template.App_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Template.Controllers
{
    public class SepetController : Controller
    {
        // GET: Cart
        public ActionResult Index()
        {
            List<SepetDetay> cartDetails = Session["Sepet"] as List<SepetDetay>;

            if (cartDetails == null)
            {
                return RedirectToAction("Index", "Urun");
            }
            else
            {
                return View(cartDetails);
            }
        }
    }
}