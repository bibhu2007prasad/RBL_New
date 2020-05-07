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
    public class HistoricalMandateOnUsController : ApiController
    {
        HistoricalMandateOnUsDataAccessLayer objHMDA = new HistoricalMandateOnUsDataAccessLayer();
        [HttpGet]
        [Route("api/BindData/DatesWiseOnUs/{FromDate}/{ToDate}/{UserId}/{EntityId}/{Reference}/{ActivityID}")]
        public IEnumerable<HistoricalMandateOnUsClass> GetDataApi(string FromDate, string ToDate, string UserId, string EntityId, string Reference, string ActivityID)
        {
            return objHMDA.GetDataFromDB(FromDate, ToDate, UserId, EntityId, Reference, ActivityID);
        }

        [HttpGet]
        // [Route("api/NachMandate/Binddetails")]
        [Route("api/BindData/BindCorpOnUs/{EntityId}")]
        public Dictionary<string, object> BindCorp(string EntityId)
        {
            return objHMDA.BindCorp(EntityId);
        }
    }
}