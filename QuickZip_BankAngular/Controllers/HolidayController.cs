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
    public class HolidayController : ApiController
    {
        HolidayDataAccessLayer objholiday = new HolidayDataAccessLayer();
        [HttpGet]
        [Route("api/Holiday/Index/{UserId}/{EntityId}")]
        public Dictionary<string, object> Index(string UserId, string EntityId)
        {
            return objholiday.GetAllHolidays(UserId,EntityId);
        }

        [HttpPost]
        [Route("api/Holiday/Create/{UserId}/{EntityId}")]
        public IEnumerable<Holiday> Create([FromBody] Holiday holiday,string UserId,string EntityId)
        {
            return objholiday.AddHoliday(holiday,UserId,EntityId);
        }
        [HttpDelete]
        [Route("api/Holiday/Delete/{id}/{UserId}/{EntityId}")]
        public IEnumerable<Holiday> Delete(int id, string UserId, string EntityId)
        {
            return objholiday.DeleteHoliday(id, UserId, EntityId);
        }
        [HttpPost]
        [Route("api/Holiday/Edit/{id}/{UserId}/{EntityId}")]
        public IEnumerable<Holiday> Edit([FromBody] Holiday holiday, int id, string UserId, string EntityId)
        {
            return objholiday.EditHoliday(holiday, id, UserId, EntityId);
        }
    }
}