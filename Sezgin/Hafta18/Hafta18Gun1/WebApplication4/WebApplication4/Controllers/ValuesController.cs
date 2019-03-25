using Contract;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication4.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<Categories> Get()
        {
            Dal _dl = new Dal();
            List<Categories> result = _dl.GetCategories();

            return result;
        }

        // GET api/values/5
        public CategoryDto Get(int id)
        {
            Dal _dl = new Dal();
            Categories category = _dl.GetCategories().FirstOrDefault(c => c.CategoryID == id);
            CategoryDto categoryDto = null;

            if (category != null)
            {
                categoryDto = new CategoryDto()
                {
                    CategoryID = category.CategoryID,
                    CategoryName = category.CategoryName,
                    Description = category.Description
                };
            }

            return categoryDto;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
