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

        // GET: Kullanici
        public ActionResult Index()
        {
            // Veritabanındaki tüm kullanıcıları çekip users isimli değişkenin içerisine atayacak.
            MembershipUserCollection users = Membership.GetAllUsers();
            return View(users);
        }
    }
}