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
using System.Net.Mail;
using PagedList;
using System.IO;

namespace AdressBook.Controllers
{
    [CustomAttributes.Authorize]
    public class PersonController : Controller
    {
        private AdressContext db = new AdressContext();

        public JsonResult Autocomplete(string term, int adressID)
        {
            term = term.Replace(" ", "");
            List<Person> people = db.People.Where(p => (p.FirstName.StartsWith(term) && p.AdressID == adressID) || 
            (p.LastName.StartsWith(term) && p.AdressID == adressID) || (p.AdressID == adressID && (p.FirstName + p.LastName).StartsWith(term)))
            .ToList();

            List<String> result = new List<string>();
            foreach(Person person in people)
            {
                result.Add(person.FirstName + " " + person.LastName);
            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index(int? adressID, string sortString, string searchString, string currentSearchString, int? page)
        {
            User holder = (User)Session["User"];
            User user = db.Users.Find(holder.ID);

            bool checker = false;
            ViewBag.CurrentSortString = sortString;
            ViewBag.NameSortParam = sortString == "Name" ? "NameDesc" : "Name";
            ViewBag.LastNameSortParam = sortString == "LastName" ? "LastNameDesc" : "LastName";
            ViewBag.GenderSortParam = sortString == "Gender" ? "GenderDesc" : "Gender";
            ViewBag.CompanySortParam = sortString == "Company" ? "CompanyDesc" : "Company";

            if (String.IsNullOrEmpty(searchString))
            {
                searchString = currentSearchString;
            }
            else
            {
                page = 1;
            }
            ViewBag.CurrentSearchString = searchString;

            if (adressID.HasValue)
            {
                foreach(Adress adr in user.Adresses)
                {
                    if(adr.ID == adressID)
                    {
                        checker = true;
                        break;
                    }
                }

                if(db.Adresses.FirstOrDefault(a => a.ID == adressID) != null && checker)
                {
                    ViewBag.Title = db.Adresses.FirstOrDefault(a => a.ID == adressID).Name;
                }
                else
                {
                    return Redirect("/Adress/Index");
                }
                ViewBag.AdressID = adressID;
                var people = db.People.Where(p => p.AdressID == adressID);

                switch (sortString)
                {
                    case "NameDesc":
                        people = people.OrderByDescending(p => p.FirstName);
                        break;
                    case "LastName":
                        people = people.OrderBy(p => p.LastName);
                        break;
                    case "LastNameDesc":
                        people = people.OrderByDescending(p => p.LastName);
                        break;
                    case "Gender":
                        people = people.OrderBy(p => p.Gender);
                        break;
                    case "GenderDesc":
                        people = people.OrderByDescending(p => p.Gender);
                        break;
                    case "Company":
                        people = people.OrderBy(p => p.Company);
                        break;
                    case "CompanyDesc":
                        people = people.OrderByDescending(p => p.Company);
                        break;
                    default:
                        people = people.OrderBy(p => p.FirstName);
                        break;
                }

                List<Person> result = new List<Person>();

                if (!String.IsNullOrEmpty(searchString))
                {
                    //string[] pieces = searchString.Split(' ');
                    searchString = searchString.Replace(" ", "");

                    people = people.Where(p => p.FirstName.StartsWith(searchString) || p.LastName.StartsWith(searchString) ||
                    p.Email.StartsWith(searchString) || p.Company.StartsWith(searchString) || 
                    ((p.FirstName + p.LastName)).StartsWith(searchString));

                    //List<Person> searchResultTotal = new List<Person>();
                    //foreach (string piece in pieces)
                    //{
                    //    List<Person> searchResult = people.Where(p => p.FirstName.StartsWith(piece) || p.LastName.StartsWith(piece)).ToList();
                    //    searchResultTotal = searchResultTotal.Union(searchResult).ToList();
                    //}
                    //result = result.Intersect(searchResultTotal).ToList();

                }

                ViewBag.AdressList = new SelectList(db.Adresses.Where(a => a.UserID == user.ID), "ID", "Name", adressID);

                int pageSize = 3;
                int pageNumber = (page ?? 1);
                //if (!String.IsNullOrEmpty(searchString))
                //    return View(result.ToPagedList(pageNumber, pageSize));

                return View(people.ToPagedList(pageNumber, pageSize));
            }
            return Redirect("/Adress/Index");
        }

        public PartialViewResult PartialIndex(int? adressID, int? page, string sortString)
        {
            User holder = (User)Session["User"];
            User user = db.Users.Find(holder.ID);

            ViewBag.NameSortParam = sortString == "Name" ? "NameDesc" : "Name";
            ViewBag.LastNameSortParam = sortString == "LastName" ? "LastNameDesc" : "LastName";
            ViewBag.GenderSortParam = sortString == "Gender" ? "GenderDesc" : "Gender";
            ViewBag.CompanySortParam = sortString == "Company" ? "CompanyDesc" : "Company";
            ViewBag.CurrentSortString = sortString;

            if (adressID.HasValue)
            {
                bool checker = false;
                foreach (Adress adr in user.Adresses)
                {
                    if (adr.ID == adressID)
                    {
                        checker = true;
                        break;
                    }
                }

                if (!checker)
                {
                    return PartialView();
                }

                string title = db.Adresses.FirstOrDefault(a => a.ID == adressID).Name;
                ViewBag.TitleFromPartial = title;
                ViewBag.AdressID = adressID;
                var people = db.People.Where(p => p.AdressID == adressID);
                people = people.OrderBy(p => p.FirstName);

                int pageNumber = (page ?? 1);
                int pageSize = 3;
                return PartialView(people.ToPagedList(pageNumber, pageSize));
            }
            return PartialView();
        }

        public ActionResult Details(int? id)
        {
            User user = (User)Session["User"];
            Person person = null;

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            foreach (Adress adr in db.Adresses.Where(a => a.UserID == user.ID))
            {
                person = adr.People.FirstOrDefault(p => p.PersonID == id);
                if (person != null)
                {
                    break;
                }
            }

            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        public ActionResult Create(int? adressID)
        {
            User holder = (User)Session["User"];
            User user = db.Users.Find(holder.ID);
            Person person = new Person();

            if (adressID.HasValue)
            {
                var exist = user.Adresses.SingleOrDefault(a => a.ID == adressID);
                if (exist != null)
                {
                    person.AdressID = adressID.Value;
                }
                else
                {
                    return Redirect("/Adress/Index");
                }
            }
            else
            {
                return Redirect("/Adress/Index");
            }
            ViewBag.AdressID = new SelectList(db.Adresses, "ID", "Name");
            return View(person);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PersonID, FirstName, LastName, Gender, Email, Company, Phone1, Phone2, AdressID, PersonAddress")] Person person, 
            HttpPostedFileBase photo)
        {
            if (ModelState.IsValid)
            {
                if(photo != null)
                {
                    string filename;
                    byte[] buffer;
                    int bytesToRead;
                    int numBytesRead = 0;

                    filename = Path.GetFileName(photo.FileName);
                    buffer = new byte[photo.ContentLength];
                    bytesToRead = (int)photo.ContentLength;

                    int n;
                    while (bytesToRead > 0)
                    {
                        n = photo.InputStream.Read(buffer, numBytesRead, bytesToRead);
                        if (n == 0)
                            break;
                        numBytesRead += n;
                        bytesToRead -= n;
                    }
                    person.Photo = buffer;
                }

                db.People.Add(person);
                db.SaveChanges();
                return RedirectToAction("Index", new { adressID = person.AdressID});
            }

            ViewBag.AdressID = new SelectList(db.Adresses, "ID", "Name", person.AdressID);
            return View(person);
        }

        public ActionResult Edit(int? id)
        {
            User holder = (User)Session["User"];
            User user = db.Users.Find(holder.ID);
            Person person = null;

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            foreach(Adress adr in db.Adresses.Where(a => a.UserID == user.ID))
            {
                person = adr.People.FirstOrDefault(p => p.PersonID == id);
                if(person != null)
                {
                    break;
                }
            }
            
            if (person == null)
            {
                return HttpNotFound();
            }
            ViewBag.AdressID = new SelectList(db.Adresses, "ID", "Name", person.AdressID);
            return View(person);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PersonID,FirstName,LastName,Gender,Email,Company,Phone1,Phone2,AdressID,PersonAddress,Photo")] Person person,
            HttpPostedFileBase photo)
        {
            if (ModelState.IsValid)
            {
                if (photo != null)
                {
                    string filename;
                    byte[] buffer;
                    int bytesToRead;
                    int numBytesRead = 0;

                    filename = Path.GetFileName(photo.FileName);
                    buffer = new byte[photo.ContentLength];
                    bytesToRead = (int)photo.ContentLength;

                    int n;
                    while (bytesToRead > 0)
                    {
                        n = photo.InputStream.Read(buffer, numBytesRead, bytesToRead);
                        if (n == 0)
                            break;
                        numBytesRead += n;
                        bytesToRead -= n;
                    }
                    person.Photo = buffer;
                }
                
                db.Entry(person).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", new { adressID = person.AdressID });
            }
            ViewBag.AdressID = new SelectList(db.Adresses, "ID", "Name", person.AdressID);
            return View(person);
        }

        public ActionResult Delete(int? id)
        {
            User holder = (User)Session["User"];
            User user = db.Users.Find(holder.ID);
            Person person = null;

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            foreach (Adress adr in db.Adresses.Where(a => a.UserID == user.ID))
            {
                person = adr.People.FirstOrDefault(p => p.PersonID == id);
                if (person != null)
                {
                    break;
                }
            }

            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Person person = db.People.Find(id);
            db.People.Remove(person);
            db.SaveChanges();
            return RedirectToAction("Index", new { adressID = person.AdressID });
        }

        public ActionResult Carry(int? id)
        {
            User holder = (User)Session["User"];
            User user = db.Users.Find(holder.ID);
            Person person = null;

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            foreach (Adress adr in db.Adresses.Where(a => a.UserID == user.ID))
            {
                person = adr.People.FirstOrDefault(p => p.PersonID == id);
                if (person != null)
                {
                    break;
                }
            }

            if (person == null)
            {
                return HttpNotFound();
            }

            ViewBag.AdressID = new SelectList(db.Adresses.Where(a => a.UserID == user.ID), "ID", "Name", person.AdressID);

            return View(person);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Carry([Bind(Include = "PersonID,FirstName,LastName,Gender,Email,Company,Phone1,Phone2,AdressID, PersonAddress, Photo")] Person person)
        {
            if (ModelState.IsValid)
            {
                db.Entry(person).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", new { adressID = person.AdressID });
            }
            ViewBag.AdressID = new SelectList(db.Adresses, "ID", "Name", person.AdressID);
            return View(person);
        }

        public ActionResult Copy(int? id)
        {
            User holder = (User)Session["User"];
            User user = db.Users.Find(holder.ID);
            Person person = null;

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            foreach (Adress adr in db.Adresses.Where(a => a.UserID == user.ID))
            {
                person = adr.People.FirstOrDefault(p => p.PersonID == id);
                if (person != null)
                {
                    break;
                }
            }

            if (person == null)
            {
                return HttpNotFound();
            }

            ViewBag.AdressID = new SelectList(db.Adresses.Where(a => a.UserID == user.ID), "ID", "Name", person.AdressID);

            return View(person);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Copy([Bind(Include = "PersonID,FirstName,LastName,Gender,Email,Company,Phone1,Phone2,AdressID, PersonAddress, Photo")] Person person)
        {
            if (ModelState.IsValid)
            {
                db.People.Add(person);
                db.SaveChanges();
                return RedirectToAction("Index", new { adressID = person.AdressID });
            }
            ViewBag.AdressID = new SelectList(db.Adresses, "ID", "Name", person.AdressID);
            return View(person);
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
