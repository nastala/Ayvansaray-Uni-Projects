using MVC_Uygulama2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Uygulama2.Controllers
{
    public class CustomerController : Controller
    {
        NorthwindModel model = new NorthwindModel();

        // GET: Customer
        public ActionResult Index()
        {
            return View(model.Customers);
        }
    }
}