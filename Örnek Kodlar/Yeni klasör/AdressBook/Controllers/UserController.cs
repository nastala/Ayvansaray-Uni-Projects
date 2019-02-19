using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdressBook.DAL;
using AdressBook.Models;
using AdressBook.Models.ViewModels.User;
using System.Net.Mail;
using System.Net;

namespace AdressBook.Controllers
{
    public class UserController : Controller
    {
        private AdressContext db = new AdressContext();

        public ActionResult Login()
        {
            User user = (User)Session["User"];
            if(user != null)
            {
                return Redirect("/Adress/Index");
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login([Bind(Include ="Username, Password")] LoginViewModel model)
        {
            Session["User"] = null;

            if (ModelState.IsValid)
            {
                User user = db.Users.FirstOrDefault(u => u.Username.Equals(model.Username));

                if (user == null)
                {
                    ViewBag.ErrorMessageForUsername = "Username doesn't exist!";
                    return View();
                }

                if (!user.Password.Equals(model.Password))
                {
                    ViewBag.ErrorMessageForPassword = "Password is wrong!";
                    return View();
                }

                Session["User"] = user;
                return Redirect("/Adress/Index");
            }

            return View();
        }

        public ActionResult Register()
        {
            User user = (User)Session["User"];
            if (user != null)
            {
                return Redirect("/Adress/Index");
            }

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register([Bind(Include ="Username, Password, Email")] User newUser) 
        {
            if (ModelState.IsValid)
            {
                foreach(User user in db.Users)
                {
                    if (user.Username.Equals(newUser.Username))
                    {
                        ViewBag.ErrorMessage = "Username already exists.";
                        return View();
                    }
                    else if (user.Email.Equals(newUser.Email))
                    {
                        ViewBag.ErrorMessageForEmail = "E-mail address is already registered!";
                        return View();
                    }
                }
                db.Users.Add(newUser);
                db.SaveChanges();

                string body = "<header><h2>Welcome to Address Book Dear " + newUser.Username + "</header><body> " +
                    "<p>You have just registered to Address Book</p>" +
                    "<p><strong>Your user details;</strong><br>" +
                    "<strong>Username: </strong> "+ newUser.Username + "<br>" +
                    "<strong>Password: </strong> " + newUser.Password+ "<br> " +
                    "<strong>E-Mail: </strong> " + newUser.Email+ "<br></p></body>";
                string subject = "Registration Complete";
                sendEmail(newUser.Email, body, subject);

                Session["User"] = newUser;

                return Redirect("/Adress/Index");
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Logout()
        {
            Session.Remove("User");

            return RedirectToAction("Login");
        }

        [CustomAttributes.Authorize]
        public ActionResult Details()
        {
            User holder = (User)Session["User"];
            User user = db.Users.Find(holder.ID);

            if (user == null)
            {
                return Redirect("/User/Login");
            }

            return View(user);
        }

        [CustomAttributes.Authorize]
        public ActionResult ChangePassword()
        {
            User holder = (User)Session["User"];
            User user = db.Users.Find(holder.ID);
            ChangePasswordViewModel model = new ChangePasswordViewModel();
            if(user != null)
            {
                model.ID = user.ID;
                model.Username = user.Username;
                model.OldPassword = user.Password;
                model.NewPassword = null;

                return View(model);
            }
            return RedirectToAction("Login");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChangePassword([Bind(Include ="ID, Username, OldPassword, NewPassword")] ChangePasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = db.Users.Find(model.ID);
                if(user == null)
                {
                    return RedirectToAction("Login");
                }

                if (!user.Password.Equals(model.OldPassword))
                {
                    ViewBag.ErrorMessageForPassword = "Password is wrong!";
                    return View();
                }

                user.Password = model.NewPassword;
                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                Session.Remove("User");

                return Redirect("/Adress/Index");
            }

            return View();
        }

        [CustomAttributes.Authorize]
        public ActionResult Delete()
        {
            User holder = (User)Session["User"];
            User user = db.Users.Find(holder.ID);
            DeleteUserViewModel model = new DeleteUserViewModel();
            model.UserID = user.ID;
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete([Bind(Include = "UserID, Password")] DeleteUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = db.Users.Find(model.UserID);
                
                if(!user.Password.Equals(model.Password))
                {
                    ViewBag.ErrorMessageForPassword = "Password is wrong.";
                    return View();
                }

                foreach(Person person in db.People)
                {
                    if(person.Adress.UserID == user.ID)
                    {
                        db.People.Remove(person);
                    }
                }
                foreach(Adress adr in db.Adresses)
                {
                    if(adr.UserID == user.ID)
                    {
                        db.Adresses.Remove(adr);
                    }
                }

                db.Users.Remove(user);
                db.SaveChanges();
                Session["User"] = null;
                return RedirectToAction("Login");
            }
            return View();
        }

        [CustomAttributes.Authorize]
        public ActionResult ChangeEmail()
        {
            User holder = (User)Session["User"];
            User user = db.Users.Find(holder.ID);
            ChangeEmailViewModel model = new ChangeEmailViewModel();
            model.UserID = user.ID;
            model.OldEmail = String.IsNullOrEmpty(user.Email) ? "-" : user.Email;
            model.NewEMail = null;
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChangeEmail([Bind(Include = "UserID,OldEmail,NewEmail")] ChangeEmailViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = db.Users.Find(model.UserID);
                foreach (User u in db.Users)
                {
                    if (!String.IsNullOrEmpty(u.Email) && u.Email.Equals(model.NewEMail))
                    {
                        ViewBag.ErrorMessageForEmail = "E-mail address is already registered!";
                        return View(model);
                    }
                }

                user.Email = model.NewEMail;
                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                Session["User"] = user;

                return RedirectToAction("Details");
            }
            return View(model);
        }

        private void sendEmail(string email, string body, string subject)
        {
            var message = new MailMessage();
            message.To.Add(new MailAddress(email));
            message.From = new MailAddress(("sezgin.games@hotmail.com"));
            message.Subject = subject;
            message.Body = body;
            message.IsBodyHtml = true;

            using (var smtp = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = "sezgin.games@hotmail.com",
                    Password = "K3m0s3z0!'"
                };
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = credential;
                smtp.Host = "smtp-mail.outlook.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Send(message);
            }
        }
    }
}