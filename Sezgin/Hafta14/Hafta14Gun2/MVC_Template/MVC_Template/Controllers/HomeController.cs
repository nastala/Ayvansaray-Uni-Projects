using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
    }
}