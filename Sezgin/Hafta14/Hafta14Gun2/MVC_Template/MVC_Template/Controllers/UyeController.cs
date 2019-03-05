using MVC_Template.App_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVC_Template.Controllers
{
    /*
     * Bu controller'a authorize attribute'u tanımladık. Ama kullanıcının giriş yapması için buraya erişebiliyor olması lazım. Çünkü giriş sayfası burada. O yüzden Giriş Action'ının View'ı çalıştıran Get Action'ına ve View'den değer alan Post Action'larına Authenticate olmayı zorunlu kılmamamız gerekiyor. 
     * 
     * Eğer bir Action'ın üzerinde Attribute varsa öncelik o Attribute'a aittir.
     */
    [Authorize]
    public class UyeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Giris(string message = null)
        {
            if (HttpContext.User != null && !string.IsNullOrWhiteSpace(HttpContext.User.Identity.Name))
                return RedirectToAction("Index", "Home");

            ViewBag.Message = message;
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Giris(string username, string password, string rememberMe)
        {
            if (Membership.ValidateUser(username, password))
            {
                // Session.Clear();  // This may not be needed -- but can't hurt
                // Session.Abandon();

                //// Clear authentication cookie
                //HttpCookie rFormsCookie = new HttpCookie(FormsAuthentication.FormsCookieName, "");
                //rFormsCookie.Expires = DateTime.Now.AddYears(-1);
                //Response.Cookies.Add(rFormsCookie);

                //// Clear session cookie 
                //HttpCookie rSessionCookie = new HttpCookie("ASP.NET_SessionId", "");
                //rSessionCookie.Expires = DateTime.Now.AddYears(-1);
                //Response.Cookies.Add(rSessionCookie);

                // Bu methodun çalışması için Web.Config'de bazı ayarların düzenlenmesi gerekir. Yani bu web sitesine üye girişi yapılabileceğine dair ayar yapmamız gerekir.
                FormsAuthentication.RedirectFromLoginPage(username, (rememberMe != null && rememberMe.Equals("on")) ? true : false);
                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Giris", new { message = "Kullanıcı adı veya parola hatalı" });
        }

        [AllowAnonymous]
        public ActionResult Kayit(string message = null)
        {
            if (HttpContext.User != null && !string.IsNullOrWhiteSpace(HttpContext.User.Identity.Name))
                return RedirectToAction("Index", "Home");

            ViewBag.Message = message;
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Kayit([Bind(Include = "Username, Email, Password, SecretQuestion, SecretAnswer")] User user)
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

                return RedirectToAction("Kayit", new { message = message });
            }

            return RedirectToAction("Kayit");
        }

        [HttpPost]
        public void Cikis()
        {
            if (HttpContext.User != null)
            {
                FormsAuthentication.SignOut();
                //Session.Clear();  // This may not be needed -- but can't hurt
                //Session.Abandon();

                //// Clear authentication cookie
                //HttpCookie rFormsCookie = new HttpCookie(FormsAuthentication.FormsCookieName, "");
                //rFormsCookie.Expires = DateTime.Now.AddYears(-1);
                //Response.Cookies.Add(rFormsCookie);

                //// Clear session cookie 
                //HttpCookie rSessionCookie = new HttpCookie("ASP.NET_SessionId", "");
                //rSessionCookie.Expires = DateTime.Now.AddYears(-1);
                //Response.Cookies.Add(rSessionCookie);
            }
        }
    }
}