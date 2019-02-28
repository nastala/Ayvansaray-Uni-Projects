using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVC_Template.Controllers
{
    public class RolController : Controller
    {

        // Websitelerinde kullanıcılara rol ataması yapılır. Aslında bir grup belirlenir ve kullanıcılar bu gruplara dahil edilir. Yetkiler gruplara tanımlanır. 
        // [dbo].[aspnet_Roles]

        // GET: Rol
        public ActionResult Index()
        {
            List<string> roles = Roles.GetAllRoles().ToList();
            return View(roles);
        }

        public ActionResult Ekle(string message = null)
        {
            ViewBag.Message = message;
            return View();
        }

        [HttpPost]
        [ActionName("Ekle")]
        public ActionResult EklePost(string role)
        {
            if (string.IsNullOrWhiteSpace(role))
                return RedirectToAction("Ekle", new { message = "Rol boş olamaz" });

            if (Roles.RoleExists(role))
                return RedirectToAction("Ekle", new { message = "Rol zaten kayıtlı" });

            Roles.CreateRole(role);
            return RedirectToAction("Ekle", new { message = "Başarılı" });
        }
    }
}