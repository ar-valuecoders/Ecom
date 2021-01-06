using System.Collections.Generic;
using E_Com.Models;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace E_Com.Controllers
{
    public class ProductsAPIController : ApiController
    {
        [HttpGet]
        public IEnumerable<Product> List()
        {
            EcomDatabaseEntities entities = new EcomDatabaseEntities();
            return entities.Products.ToList();
        }

        [HttpGet]
        public IEnumerable<Product> Search(int id)
        {
            EcomDatabaseEntities entities = new EcomDatabaseEntities();
            return entities.Products.Where(x => x.ProductID == id).ToList();
        }


        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}