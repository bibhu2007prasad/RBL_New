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
        [Route("api/Designation/Index")]
        public Dictionary<string, object> Index()
        {
            return objdesignation.GetAllDesignations();
        }

        [HttpPost]
        [Route("api/Designation/Create")]
        public IEnumerable<Designation> Create([FromBody] Designation designation)
        {
            return objdesignation.AddDesignation(designation);
        }
        [HttpDelete]
        [Route("api/Designation/Delete/{id}")]
        public IEnumerable<Designation> Delete(int id)
        {
            return objdesignation.DeleteDesignation(id);
        }
        [HttpPost]
        [Route("api/Designation/Edit/{id}")]
        public IEnumerable<Designation> Edit([FromBody] Designation designation, int id)
        {
            return objdesignation.EditDesignation(designation, id);
        }
    }
}