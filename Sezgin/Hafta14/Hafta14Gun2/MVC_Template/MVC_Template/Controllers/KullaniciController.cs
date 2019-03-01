using MVC_Template.App_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVC_Template.Controllers
{
    public class KullaniciController : Controller
    {
        // Buradaki sayfaları sadece Admin rolüne sahip olan görebilecek.
        // [dbo].[aspnet_Users], [dbo].[aspnet_UsersInRoles], [dbo].[aspnet_Membership]

        // GET: Kullanici
        public ActionResult Index()
        {
            // Veritabanındaki tüm kullanıcıları çekip users isimli değişkenin içerisine atayacak.
            MembershipUserCollection users = Membership.GetAllUsers();
            return View(users);
        }

        public ActionResult Ekle(string message = null)
        {
            ViewBag.Message = message;

            return View();
        }

        [HttpPost]
        public ActionResult Ekle([Bind(Include = "Username, Password, Email, SecretQuestion, SecretAnswer")] User user)
        {
            if (ModelState.IsValid)
            {
                Membership.CreateUser(user.Username, user.Password, user.Email, user.SecretQuestion, user.SecretAnswer, true, out MembershipCreateStatus status);

                string message;
                switch (status)
                {
                    case MembershipCreateStatus.Success:
                        message = "Başarılı";
                        break;
                    case MembershipCreateStatus.InvalidUserName:
                        message = "Kullanıcı adı geçersiz.";
                        break;
                    case MembershipCreateStatus.InvalidPassword:
                        message = "Şifre geçersiz";
                        break;
                    case MembershipCreateStatus.InvalidQuestion:
                        message = "Gizli soru geçersiz";
                        break;
                    case MembershipCreateStatus.InvalidAnswer:
                        message = "Gizli cevap geçersiz";
                        break;
                    case MembershipCreateStatus.InvalidEmail:
                        message = "E-posta geçersiz";
                        break;
                    case MembershipCreateStatus.DuplicateUserName:
                        message = "Bu kullanıcı adı zaten kayıtlı";
                        break;
                    case MembershipCreateStatus.DuplicateEmail:
                        message = "Bu e-posta adresi zaten kayıtlı";
                        break;
                    case MembershipCreateStatus.UserRejected:
                        message = "Kullanıcı engellendi.";
                        break;
                    case MembershipCreateStatus.InvalidProviderUserKey:
                        message = "Sunucu anahtarı geçersiz";
                        break;
                    case MembershipCreateStatus.DuplicateProviderUserKey:
                        message = "Sunucu anahtarı zaten kayıtlı";
                        break;
                    case MembershipCreateStatus.ProviderError:
                        message = "Sunucu hatası";
                        break;
                    default:
                        message = "Başarılı";
                        break;
                }

                return RedirectToAction("Ekle", new { message = message });
            }

            return View();
        }

        public ActionResult RolAta(string username, string message = null)
        {
            /* Parametre olarak id yazmak zorundayız, sebebi projenin App_Start klasörünün altında Route_Config.cs dosyasında "{controller}/{action}/{id}" bu parametre adının default adı id olduğu için parametre adının da id olması gerekiyor. 
             *  
             *  Kullanıcı RolAta'ya tıklandığında kullanıcı adını parametre olarak buraya alıyoruz. Buradan da kullanıcının adını View'e gönderiyoruz. Amacımız parametre bilgisini View'e taşımak. View tarafında Ekle butonuna basınca tekrar kullanıcı adını ve rol adını View'den alıp Post tarafına taşımak.
             */

            if (string.IsNullOrWhiteSpace(username))
                return RedirectToAction("Index");

            MembershipUser user = Membership.GetUser(username);

            if (user == null)
                return HttpNotFound();

            string[] userRoles = Roles.GetRolesForUser(username);
            string[] allRoles = Roles.GetAllRoles();

            List<string> availableRoles = new List<string>();
            foreach (string role in allRoles)
            {
                if (!userRoles.Contains(role))
                    availableRoles.Add(role);
            }

            ViewBag.AvailableRoles = availableRoles;
            ViewBag.UserRoles = userRoles;
            ViewBag.Username = username;
            ViewBag.Message = message;

            return View();
        }

        [HttpPost]
        public ActionResult RolAta(string username, List<string> addedRoles)
        {
            if (addedRoles.Count < 1)
                return RedirectToAction("RolAta", new { username = username, message = "Hata" });

            Roles.AddUserToRoles(username, addedRoles.ToArray());

            return RedirectToAction("RolAta", new { username = username, message = "Başarılı" });
        }

        [HttpPost]
        public string RolSil(string username, string removedRoles)
        {
            string[] removedRolesArray = removedRoles.Split(',');

            if (removedRolesArray.Length < 1 || string.IsNullOrWhiteSpace(removedRolesArray[0]))
                return "Hata";

            Roles.RemoveUserFromRoles(username, removedRolesArray);

            return "Başarılı";
        }
    }
}