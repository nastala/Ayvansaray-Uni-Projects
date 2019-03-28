using MVC_Template.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Template.App_Classes
{
    public class CustomActionFilterAttribute : ActionFilterAttribute
    {
        private NorthwindContext _model = new NorthwindContext();

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            RequestLog requestLog = new RequestLog()
            {
                RequestDate = DateTime.Now,
                RequestUrl = filterContext.HttpContext.Request.RawUrl
            };

            _model.RequestLogs.Add(requestLog);
            _model.SaveChanges();
            base.OnActionExecuting(filterContext);
        }
    }
}