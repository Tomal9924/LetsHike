using InterfaceClass;
using EntityClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Repository;

namespace Api.Controllers
{
    [RoutePrefix("api/Packages")]
    public class PackageController : ApiController
    {

         private IPackageRepository packageRepo;
         
        public PackageController()
        {
            this.packageRepo = new PackageRepository();
        }
         //show all
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(this.packageRepo.GetAll());
        }
         //details

        [Route("{id}", Name = "GetPackageById")]
        public IHttpActionResult Get(int id)
        {
            Package packageId = this.packageRepo.Get(id);
            if (packageId == null)
            {
                return StatusCode(HttpStatusCode.NoContent);
            }
            return Ok(packageId);
        }

         //insert
        [Route("")]
        public IHttpActionResult Post(Package packageObj)
        {
            this.packageRepo.Insert(packageObj);
            string uri = Url.Link("GetPackageById", new { id = packageObj.Package_Id });
            return Created(uri, packageObj);
        }
         //update

        [Route("{id}")]
        public IHttpActionResult Put([FromBody]Package packageobj2, [FromUri]int id)
        {
            packageobj2.Package_Id = id;
            this.packageRepo.Update(packageobj2);
            return Ok(packageobj2);
        }

         //delete
        [Route("{id}")]
        public IHttpActionResult Delete(int id)
        {
            this.packageRepo.Delete(this.packageRepo.Get(id));
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
    }

