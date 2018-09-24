using EntityClass;
using InterfaceClass;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers
{
    [RoutePrefix("api/Products")]
    public class ProductController : ApiController
    {
        private IProductRepository repo;
        public ProductController()
        {
            this.repo = new ProductRepository();
        }
        //show all
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(this.repo.GetAll());
        }
        //details

        [Route("{id}", Name = "GetProductById")]
        public IHttpActionResult Get(int id)
        {
            Product pId = this.repo.Get(id);
            if (pId == null)
            {
                return StatusCode(HttpStatusCode.NoContent);
            }
            return Ok(pId);
        }

        //insert
        [Route("")]
        public IHttpActionResult Post(Product CustomerObj)
        {
            this.repo.Insert(CustomerObj);
            string uri = Url.Link("GetProductById", new { id = CustomerObj.Product_Id });
            return Created(uri, CustomerObj);
        }
        //update

        [Route("{id}")]
        public IHttpActionResult Put([FromBody]Product CustomerObj2, [FromUri]int id)
        {
            CustomerObj2.Product_Id = id;
            this.repo.Update(CustomerObj2);
            return Ok(CustomerObj2);
        }

        //delete
        [Route("{id}")]
        public IHttpActionResult Delete(int id)
        {
            this.repo.Delete(this.repo.Get(id));
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
