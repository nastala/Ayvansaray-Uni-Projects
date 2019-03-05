using MVC_Template.App_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_Template
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected void Session_Start()
        {
            if (HttpContext.Current.User == null || string.IsNullOrWhiteSpace(HttpContext.Current.User.Identity.Name))
                return;

            int sayac = 0;
            if (Application["AktifKullanici"] == null)
                sayac = 1;
            else
            {
                sayac = (int)Application["AktifKullanici"];
                sayac++;
            }

            Application["AktifKullanici"] = sayac;
        }

        protected void Session_End()
        {
            int sayac = 0;
            if (Application["AktifKullanici"] != null)
                sayac = (int)Application["AktifKullanici"] - 1;

            Application["AktifKullanici"] = sayac;
        }
    }
}
