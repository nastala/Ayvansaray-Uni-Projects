using E_Ticaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Ticaret.Controllers
{
    public class AdminController : Controller
    {
        private Model _model = new Model();

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Products()
        {
            return View(_model.Products.ToList());
        }

        public ActionResult AddProduct()
        {
            return View();
        }
    }
}