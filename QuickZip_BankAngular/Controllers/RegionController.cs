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
    public class RegionController : ApiController
    {
        RegionMasterDataAccessLayer objregionMaster = new RegionMasterDataAccessLayer();

        [HttpGet]
        
        [Route("api/RegionMaster/BindStates/{UserId}/{EntityId}")]
        public Dictionary<string, object> BindStates(string UserId, string EntityId)
        {
            return objregionMaster.BindStates(UserId, EntityId);
        }

        [HttpGet]
        [Route("api/RegionMaster/Index/{UserId}/{EntityId}")]
        public Dictionary<string, object> Index(string UserId, string EntityId)
        {
            return objregionMaster.GetAllRegionMasters(UserId, EntityId);
        }

        [HttpPost]
        [Route("api/RegionMaster/Create/{UserId}/{EntityId}")]
        public IEnumerable<RegionMaster> Create([FromBody] RegionMaster RegionMaster, string UserId, string EntityId)
        {
            return objregionMaster.AddRegionMaster(RegionMaster, UserId, EntityId);
        }
        //[HttpDelete]
        //[Route("api/RegionMaster/Delete/{id}")]
        //public IEnumerable<RegionMaster> Delete(int id)
        //{
        //    return objregionMaster.DeleteDocument(id);
        //}
        [HttpPost]
        [Route("api/RegionMaster/Edit/{UserId}/{EntityId}/{id}")]
        public IEnumerable<RegionMaster> Edit([FromBody] RegionMaster RegionMaster, string UserId, string EntityId, int id)
        {
            return objregionMaster.EditRegionMaster(RegionMaster, UserId, EntityId, id);
        }
    }
}