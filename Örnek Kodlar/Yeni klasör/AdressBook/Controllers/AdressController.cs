using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AdressBook.DAL;
using AdressBook.Models;
using AdressBook.CustomAttributes;
using PagedList;

namespace AdressBook.Controllers
{
    [CustomAttributes.Authorize]
    public class AdressController : Controller
    {
        private AdressContext db = new AdressContext();

        public ActionResult Index(string sortString, int? page)
        {
            ViewBag.CurrentSortParam = sortString;
            ViewBag.AddressNameSortParam = String.IsNullOrEmpty(sortString) ? "NameDesc" : "";
            User holder = (User)Session["User"];
            User user = db.Users.Find(holder.ID);

            var adresses = db.Adresses.Where(a => a.UserID == user.ID);
            switch (sortString)
            {
                case "NameDesc":
                    adresses = adresses.OrderByDescending(a => a.Name);
                    break;
                default:
                    adresses = adresses.OrderBy(a => a.Name);
                    break;
            }

            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(adresses.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult Details(int? id)
        {
            User holder = (User)Session["User"];
            User user = db.Users.Find(holder.ID);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Adress adress = db.Adresses.FirstOrDefault(a => a.UserID == user.ID && a.ID == id);

            if (adress == null)
            {
                return HttpNotFound();
            }
            return View(adress);
        }

        public ActionResult Create()
        {
            User holder = (User)Session["User"];
            User user = db.Users.Find(holder.ID);
            
            Adress adress = new Adress();
            adress.UserID = user.ID;
            return View(adress);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserID, Name")] Adress adress)
        {
            if (ModelState.IsValid)
            {
                db.Adresses.Add(adress);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(adress);
        }

        public ActionResult Edit(int? id)
        {
            User holder = (User)Session["User"];
            User user = db.Users.Find(holder.ID);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Adress adress = db.Adresses.FirstOrDefault(a => a.UserID == user.ID && a.ID == id);

            if (adress == null)
            {
                return HttpNotFound();
            }
            return View(adress);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID, Name, UserID")] Adress adress)
        {
            if (ModelState.IsValid)
            {
                db.Entry(adress).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(adress);
        }

        public ActionResult Delete(int? id)
        {
            User holder = (User)Session["User"];
            User user = db.Users.Find(holder.ID);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Adress adress = db.Adresses.FirstOrDefault(a => a.UserID == user.ID && a.ID == id);

            if (adress == null)
            {
                return HttpNotFound();
            }
            return View(adress);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Adress adress = db.Adresses.Find(id);
            foreach(Person person in adress.People.ToList())
            {
                db.People.Remove(person);
            }

            db.Adresses.Remove(adress);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
