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
    public class SettlementTypeController : ApiController
    {
        SettlementTypeDataAccessLayer objSettlement = new SettlementTypeDataAccessLayer();

        [HttpGet]
        // [Route("api/NachMandate/Binddetails")]
        [Route("api/Settlement/BindSettlementType/{UserId}/{EntityId}")]
        public Dictionary<string, object> BindSettlementType(string UserId, string EntityId)
        {
            return objSettlement.BindSettlementType(UserId, EntityId);
        }

        [HttpGet]
        [Route("api/SettlementType/Index/{UserId}/{EntityId}")]
        public Dictionary<string, object> Index(string UserId, string EntityId)
        {
            return objSettlement.GetAllSettlementTypes(UserId, EntityId);
        }

        [HttpPost]
        [Route("api/SettlementType/Create/{UserId}/{EntityId}")]
        public IEnumerable<SettlementTypeM> Create([FromBody] SettlementTypeM SettlementTypeM, string UserId, string EntityId)
        {
            return objSettlement.AddSettlementType(SettlementTypeM, UserId, EntityId);
        }
        //[HttpDelete]
        //[Route("api/SettlementTypeM/Delete/{id}")]
        //public IEnumerable<SettlementTypeM> Delete(int id)
        //{
        //    return objSettlement.DeleteDocument(id);
        //}
        [HttpPost]
        [Route("api/SettlementType/Edit/{UserId}/{EntityId}/{id}")]
        public IEnumerable<SettlementTypeM> Edit([FromBody] SettlementTypeM SettlementTypeM, string UserId, string EntityId, int id)
        {
            return objSettlement.EditSettlementType(SettlementTypeM, UserId, EntityId, id);
        }
    }
}