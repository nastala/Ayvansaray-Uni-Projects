using E_Ticaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Ticaret.MyModelBinders
{
    public class ProductModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var request = controllerContext.HttpContext.Request;
            int id = Convert.ToInt32(request.Form.Get("id"));

            Model model = new Model();
            var result= model.Products.Find(id);
            return result;
        }
    }
}