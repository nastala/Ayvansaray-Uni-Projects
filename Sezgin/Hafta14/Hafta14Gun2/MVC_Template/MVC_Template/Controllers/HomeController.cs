using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVC_Template.Controllers
{
    /*
     * Bu controller üzerindeki actionlara erişebilmek için kullanıcının giriş yapması lazım. Eğer kullanıcı Authenticate değilse actionları kullanamayacak.
     * */
    [Authorize]
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // Cookie'ye değer atamamızı sağlayan bir Action'ımız olsun
        public ActionResult CookieAta()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CookieAta(string cookieName, string cookieValue)
        {
            if (string.IsNullOrWhiteSpace(cookieName) || string.IsNullOrWhiteSpace(cookieValue))
                return View();

            HttpCookie cookie = new HttpCookie(cookieName, cookieValue);
            cookie.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(cookie);

            return RedirectToAction("Index");
        }

        public ActionResult CookieOku()
        {
            HttpCookie cookie = Request.Cookies.Get("Test");
            return View(cookie);
        }
    }
}