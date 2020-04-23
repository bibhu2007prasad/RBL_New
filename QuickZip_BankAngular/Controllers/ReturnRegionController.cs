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
    public class ReturnRegionController : ApiController
    {
        ReturnRegionDataAccessLayer objreturnRegion = new ReturnRegionDataAccessLayer();

        [HttpGet]
        [Route("api/ReturnRegionMaster/Index/{UserId}/{EntityId}")]
        public Dictionary<string, object> Index(string UserId, string EntityId)
        {
            return objreturnRegion.GetAllReturnRegionMasters(UserId, EntityId);
        }

        [HttpPost]
        [Route("api/ReturnRegionMaster/Create/{UserId}/{EntityId}")]
        public IEnumerable<ReturnRegionMaster> Create([FromBody] ReturnRegionMaster ReturnRegionMaster, string UserId, string EntityId)
        {
            return objreturnRegion.AddReturnRegionMaster(ReturnRegionMaster, UserId, EntityId);
        }
        //[HttpDelete]
        //[Route("api/ReturnRegionMaster/Delete/{id}")]
        //public IEnumerable<ReturnRegionMaster> Delete(int id)
        //{
        //    return objreturnRegion.DeleteDocument(id);
        //}
        [HttpPost]
        [Route("api/ReturnRegionMaster/Edit/{UserId}/{EntityId}/{id}")]
        public IEnumerable<ReturnRegionMaster> Edit([FromBody] ReturnRegionMaster ReturnRegionMaster, string UserId, string EntityId, int id)
        {
            return objreturnRegion.EditReturnRegionMaster(ReturnRegionMaster, UserId, EntityId, id);
        }
    }
}