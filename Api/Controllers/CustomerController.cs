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
     [RoutePrefix("api/Customers")]
    public class CustomerController : ApiController
    {
         private ICustomerRepository repo;
        public CustomerController()
        {
            this.repo = new CustomerRepository();
        }
         //show all
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(this.repo.GetAll());
        }
         //details

        [Route("{id}", Name = "GetCustomerById")]
        public IHttpActionResult Get(int id)
        {
            Customer customerId = this.repo.Get(id);
            if (customerId == null)
            {
                return StatusCode(HttpStatusCode.NoContent);
            }
            return Ok(customerId);
        }

         //insert
        [Route("")]
        public IHttpActionResult Post(Customer CustomerObj)
        {
            this.repo.Insert(CustomerObj);
            string uri = Url.Link("GetCustomerById", new { id = CustomerObj.Customer_Id });
            return Created(uri, CustomerObj);
        }
         //update

        [Route("{id}")]
        public IHttpActionResult Put([FromBody]Customer CustomerObj2, [FromUri]int id)
        {
            CustomerObj2.Customer_Id = id;
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
