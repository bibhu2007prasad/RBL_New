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
        [Route("api/Employee/Index")]
        public Dictionary<string, object> Index()
        {
            return objemployee.GetAllEmployees();
        }





        [HttpPost]
        [Route("api/Employee/Create")]
        public IEnumerable<Employee> Create([FromBody] Employee employee)
        {
            return objemployee.AddEmployee(employee);
        }
        [HttpDelete]
        [Route("api/Employee/Delete/{id}")]
        public IEnumerable<Employee> Delete(int id)
        {
            return objemployee.DeleteEmployee(id);
        }
        [HttpPost]
        [Route("api/Employee/Edit/{id}")]
        public IEnumerable<Employee> Edit([FromBody] Employee employee,int id)
        {
            return objemployee.EditEmp(employee,id);
        }
    }
}