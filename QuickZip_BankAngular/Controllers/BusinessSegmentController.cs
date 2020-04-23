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
    public class BusinessSegmentController : ApiController
    {
        BusinessSegmentDataAccessLayer objBusinessSegment = new BusinessSegmentDataAccessLayer();

        [HttpGet]
        [Route("api/BusinessSegment/Index/{UserId}/{EntityId}")]
        public Dictionary<string, object> Index(string UserId, string EntityId)
        {
            return objBusinessSegment.GetAllBusinessSegments(UserId, EntityId);
        }

        [HttpPost]
        [Route("api/BusinessSegment/Create/{UserId}/{EntityId}")]
        public IEnumerable<BusinessSegment> Create([FromBody] BusinessSegment BusinessSegment, string UserId, string EntityId)
        {
            return objBusinessSegment.AddBusinessSegment(BusinessSegment, UserId, EntityId);
        }
        //[HttpDelete]
        //[Route("api/BusinessSegment/Delete/{id}")]
        //public IEnumerable<BusinessSegment> Delete(int id)
        //{
        //    return objSettlement.DeleteDocument(id);
        //}
        [HttpPost]
        [Route("api/BusinessSegment/Edit/{UserId}/{EntityId}/{id}")]
        public IEnumerable<BusinessSegment> Edit([FromBody] BusinessSegment BusinessSegment, string UserId, string EntityId, int id)
        {
            return objBusinessSegment.EditBusinessSegment(BusinessSegment, UserId, EntityId, id);
        }
    }
}