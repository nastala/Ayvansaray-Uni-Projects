using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AdressBook.CustomAttributes
{
    public class AuthorizeAttribute : ActionFilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            var user = filterContext.HttpContext.Session["User"];
            if (user == null)
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary { { "controller", "user" }, { "action", "login" } });
            }
        }
    }
}