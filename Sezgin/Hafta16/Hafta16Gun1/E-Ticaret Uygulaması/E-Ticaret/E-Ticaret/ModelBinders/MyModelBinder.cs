using E_Ticaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Ticaret.App_ModelBinders
{
    public class MyModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var request = controllerContext.HttpContext.Request;

            return new Product
            {
                Name = request.Form.Get("Name") + " hahahaha",
                CategoryID = Convert.ToInt32(request.Form.Get("CategoryID")),
                PurchasePrice = -1
            };
        }
    }
}