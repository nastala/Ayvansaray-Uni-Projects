using E_Ticaret.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
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

        public ActionResult Brands()
        {
            return View(_model.Brands.ToList());
        }

        public ActionResult AddBrand()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddBrand([Bind(Include = "Name, Description")] Brand brand, HttpPostedFileBase fileUpload)
        {
            if (fileUpload != null)
            {
                Image img = Image.FromStream(fileUpload.InputStream);
                int width = Convert.ToInt32(ConfigurationManager.AppSettings["BrandWidth"].ToString());
                int height = Convert.ToInt32(ConfigurationManager.AppSettings["BrandHeight"].ToString());
                string name = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(fileUpload.FileName);
                var path = Path.Combine(Server.MapPath("~/Uploads/Photos/"), name);

                //string name="/Content/BrandPictures/" +Guid.NewGuid()+ Path.GetExtension(fileUpload.FileName);
                //Bitmap bmp = new Bitmap(img, width, height);
                //bmp.Save(Server.MapPath(name));
                fileUpload.SaveAs(path);
                BrandPicture pic = new BrandPicture();
                pic.MediumPath = name;
                pic.IsDefault = true;
                brand.BrandPicture = pic;
                _model.Brands.Add(brand);
                _model.SaveChanges();

                return RedirectToAction("Brands");
            }

            return View();
        }
    }
}