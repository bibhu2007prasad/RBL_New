using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuickZip_BankAngular.Models;
using System.Threading.Tasks;

namespace QuickZip_BankAngular.Controllers
{
    public class EmployeeController : ApiController
    {
        EmployeeDataAccessLayer objemployee = new EmployeeDataAccessLayer();

       [HttpGet]
        // [Route("api/NachMandate/Binddetails")]
        [Route("api/Employee/BindDesignation/{UserId}/{EntityId}")]
        public Dictionary<string, object> BindDesignation(string UserId, string EntityId)
        {
            return objemployee.BindDesignation(UserId, EntityId);
        }

        [HttpGet]
        [Route("api/Employee/Index/{UserId}/{EntityId}")]
        public Dictionary<string, object> Index(string UserId, string EntityId)
        {
            return objemployee.GetAllEmployees(UserId, EntityId);
        }

        [HttpPost]
        [Route("api/Employee/Create/{UserId}/{EntityId}")]
        public IEnumerable<Employee> Create([FromBody] Employee Employee, string UserId, string EntityId)
        {
            return objemployee.AddEmployee(Employee, UserId, EntityId);
        }
        //[HttpDelete]
        //[Route("api/Employee/Delete/{id}")]
        //public IEnumerable<Employee> Delete(int id)
        //{
        //    return objemployee.DeleteDocument(id);
        //}
        [HttpPost]
        [Route("api/Employee/Edit/{UserId}/{EntityId}/{id}")]
        public IEnumerable<Employee> Edit([FromBody] Employee Employee, string UserId, string EntityId, int id)
        {
            return objemployee.EditEmployee(Employee, UserId, EntityId, id);
        }
    }
}