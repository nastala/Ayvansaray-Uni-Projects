using MVC_Template.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Template.Controllers
{
    public class CategoryController : Controller
    {
        private NorthwindModel _model = new NorthwindModel();

        // GET: Category
        public ActionResult Index()
        {
            return View(_model.Categories.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "CategoryName, Description")] Category category, HttpPostedFileBase picture)
        {
            if (picture == null)
                return View();

            if (!HttpPostedFileBaseExtensions.IsImage(picture))
                return View();

            category.Picture = ConvertToBytes(picture);

            if (ModelState.IsValid)
            {
                _model.Categories.Add(category);
                _model.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        public byte[] ConvertToBytes(HttpPostedFileBase image)
        {
            byte[] imageBytes = null;
            BinaryReader reader = new BinaryReader(image.InputStream);
            imageBytes = reader.ReadBytes((int)image.ContentLength);
            return imageBytes;
        }
    }
}