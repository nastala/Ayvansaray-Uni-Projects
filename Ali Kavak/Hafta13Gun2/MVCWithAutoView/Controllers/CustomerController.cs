using MVCWithAutoView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWithAutoView.Controllers
{
    public class CustomerController : Controller
    {
        NortwindModel _model = new NortwindModel();
        // GET: Customer
        public ActionResult Index()
        {
            return View(_model.Customers);
        }
    }
}