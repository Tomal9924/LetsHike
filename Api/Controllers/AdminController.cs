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
    [RoutePrefix("api/Admins")]
    public class AdminController : ApiController
    {
        private IAdminRepository repo;
        public AdminController()
        {
            this.repo = new AdminRepository();
        }
        //show all
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(this.repo.GetAll());
        }
        //details

        [Route("{id}", Name = "GetAdminById")]
        public IHttpActionResult Get(int id)
        {
            Admin adminId = this.repo.Get(id);
            if (adminId == null)
            {
                return StatusCode(HttpStatusCode.NoContent);
            }
            return Ok(adminId);
        }

        //insert
        [Route("")]
        public IHttpActionResult Post(Admin CustomerObj)
        {
            this.repo.Insert(CustomerObj);
            string uri = Url.Link("GetAdminById", new { id = CustomerObj.Admin_Id });
            return Created(uri, CustomerObj);
        }
        //update

        [Route("{id}")]
        public IHttpActionResult Put([FromBody]Admin CustomerObj2, [FromUri]int id)
        {
            CustomerObj2.Admin_Id = id;
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
