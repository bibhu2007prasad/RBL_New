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
    public class BranchMasterController : ApiController
    {
        BranchMasterDataAccessLayer objbranchMaster = new BranchMasterDataAccessLayer();

        [HttpGet]
        // [Route("api/NachMandate/Binddetails")]
        [Route("api/BranchMaster/BindStates/{UserId}/{EntityId}")]
        public Dictionary<string, object> BindStates(string UserId, string EntityId)
        {
            return objbranchMaster.BindStates(UserId, EntityId);
        }

        [HttpGet]
        [Route("api/BranchMaster/Index/{UserId}/{EntityId}")]
        public Dictionary<string, object> Index(string UserId, string EntityId)
        {
            return objbranchMaster.GetAllBranchMasters(UserId, EntityId);
        }

        [HttpPost]
        [Route("api/BranchMaster/Create/{UserId}/{EntityId}")]
        public IEnumerable<BranchMaster> Create([FromBody] BranchMaster BranchMaster, string UserId, string EntityId)
        {
            return objbranchMaster.AddBranchMaster(BranchMaster, UserId, EntityId);
        }
        //[HttpDelete]
        //[Route("api/BranchMaster/Delete/{id}")]
        //public IEnumerable<BranchMaster> Delete(int id)
        //{
        //    return objbranchMaster.DeleteDocument(id);
        //}
        [HttpPost]
        [Route("api/BranchMaster/Edit/{UserId}/{EntityId}/{id}")]
        public IEnumerable<BranchMaster> Edit([FromBody] BranchMaster BranchMaster, string UserId, string EntityId, int id)
        {
            return objbranchMaster.EditBranchMaster(BranchMaster, UserId, EntityId, id);
        }
    }
}