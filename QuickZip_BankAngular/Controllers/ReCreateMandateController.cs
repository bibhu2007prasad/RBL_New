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
    public class ReCreateMandateController : ApiController
    {
        ReCreateDataAccessLayer objHMDA = new ReCreateDataAccessLayer();
        [HttpGet]
        [Route("api/BindData/ReCreateMandate/{FromDate}/{ToDate}/{UserId}/{EntityId}/{MandateId}/{Reference}/{ActivityID}")]
        public IEnumerable<MandateDetails> BindMandateDetails(string FromDate, string ToDate, string UserId, string EntityId,string MandateId, string Reference, string ActivityID)
        {
            return objHMDA.BindMandateDetails(FromDate, ToDate, UserId, EntityId, MandateId,Reference, ActivityID);
        }

        
    }
}