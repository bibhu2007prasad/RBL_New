using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuickZip_BankAngular.Models;
using System.Threading.Tasks;

namespace QuickZip_BankAngular.Controllers
{
    public class DesignationController : ApiController
    {
        DesignationDataAccessLayer objdesignation = new DesignationDataAccessLayer();
        [HttpGet]
        [Route("api/Designation/Index/{UserId}/{EntityId}")]
        public Dictionary<string, object> Index(string UserId, string EntityId)
        {
            return objdesignation.GetAllDesignations(UserId, EntityId);
        }

        [HttpPost]
        [Route("api/Designation/Create/{UserId}/{EntityId}")]
        public IEnumerable<Designation> Create([FromBody] Designation designation, string UserId, string EntityId)
        {
            return objdesignation.AddDesignation(designation,UserId, EntityId);
        }
        [HttpDelete]
        [Route("api/Designation/Delete/{id}/{UserId}/{EntityId}")]
        public IEnumerable<Designation> Delete(int id, string UserId, string EntityId)
        {
            return objdesignation.DeleteDesignation(id,UserId, EntityId);
        }
        [HttpPost]
        [Route("api/Designation/Edit/{id}/{UserId}/{EntityId}")]
        public IEnumerable<Designation> Edit([FromBody] Designation designation, int id, string UserId, string EntityId)
        {
            return objdesignation.EditDesignation(designation, id, UserId, EntityId);
        }
    }
}