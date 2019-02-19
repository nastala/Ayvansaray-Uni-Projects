using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdressBook.CustomAttributes;

namespace AdressBook.Controllers
{
    [CustomAttributes.Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        
    }
}