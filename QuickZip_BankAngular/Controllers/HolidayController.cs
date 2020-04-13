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
        [Route("api/Holiday/Index")]
        public Dictionary<string, object> Index()
        {
            return objholiday.GetAllHolidays();
        }

        [HttpPost]
        [Route("api/Holiday/Create")]
        public IEnumerable<Holiday> Create([FromBody] Holiday holiday)
        {
            return objholiday.AddHoliday(holiday);
        }
        [HttpDelete]
        [Route("api/Holiday/Delete/{id}")]
        public IEnumerable<Holiday> Delete(int id)
        {
            return objholiday.DeleteHoliday(id);
        }
        [HttpPost]
        [Route("api/Holiday/Edit/{id}")]
        public IEnumerable<Holiday> Edit([FromBody] Holiday holiday, int id)
        {
            return objholiday.EditHoliday(holiday, id);
        }
    }
}