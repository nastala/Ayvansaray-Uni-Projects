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
            ViewBag.Message = message;
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Giris(string username, string password, string rememberMe)
        {
            if (Membership.ValidateUser(username, password))
            {
                // Bu methodun çalışması için Web.Config'de bazı ayarların düzenlenmesi gerekir. Yani bu web sitesine üye girişi yapılabileceğine dair ayar yapmamız gerekir.
                FormsAuthentication.RedirectFromLoginPage(username, (rememberMe != null && rememberMe.Equals("on")) ? true : false);
                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Giris", new { message = "Kullanıcı adı veya parola hatalı" });
        }
    }
}