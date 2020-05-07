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
    public class ChageMasterController : ApiController
    {
        ChargeMasterDataAccessLayer objChargeMaster = new ChargeMasterDataAccessLayer();

        [HttpGet]
        [Route("api/ChargeMaster/Index/{UserId}/{EntityId}")]
        public Dictionary<string, object> Index(string UserId, string EntityId)
        {
            return objChargeMaster.GetAllChargeMasters(UserId, EntityId);
        }

        [HttpPost]
        [Route("api/ChargeMaster/Create/{UserId}/{EntityId}")]
        public IEnumerable<ChargeMaster> Create([FromBody] ChargeMaster ChargeMaster, string UserId, string EntityId)
        {
            return objChargeMaster.AddChargeMaster(ChargeMaster, UserId, EntityId);
        }
        //[HttpDelete]
        //[Route("api/ChargeMaster/Delete/{id}")]
        //public IEnumerable<ChargeMaster> Delete(int id)
        //{
        //    return objSettlement.DeleteDocument(id);
        //}
        [HttpPost]
        [Route("api/ChargeMaster/Edit/{UserId}/{EntityId}/{id}")]
        public IEnumerable<ChargeMaster> Edit([FromBody] ChargeMaster ChargeMaster, string UserId, string EntityId, int id)
        {
            return objChargeMaster.EditChargeMaster(ChargeMaster, UserId, EntityId, id);
        }
    }
}