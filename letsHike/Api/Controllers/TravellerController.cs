using InterfaceClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EntityClass;
using Repository;

namespace Api.Controllers
{
    [RoutePrefix("api/Travellers")]
    public class TravellerController : ApiController
    {
        private ITravellerRepository repo;

        public TravellerController()
        {
            this.repo = new TravellerRepository();
        }

        //show all
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(this.repo.GetAll());
        }

        //details

        [Route("{id}", Name = "GetTravellerById")]
        public IHttpActionResult Get(int id)
        {
            Traveller travellerId = this.repo.Get(id);
            if (travellerId == null)
            {
                return StatusCode(HttpStatusCode.NoContent);
            }
            return Ok(travellerId);
        }
        //insert
        [Route("")]
        public IHttpActionResult Post(Traveller packageObj)
        {
            this.repo.Insert(packageObj);
            string uri = Url.Link("GetTravellerById", new { id = packageObj.Traveller_Id });
            return Created(uri, packageObj);
        }
        //update

        [Route("{id}")]
        public IHttpActionResult Put([FromBody]Traveller packageobj2, [FromUri]int id)
        {
            packageobj2.Traveller_Id = id;
            this.repo.Update(packageobj2);
            return Ok(packageobj2);
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
