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
    public class MandateRegInWardUnderProcessedController : ApiController
    {
        MandateRegInWardUnProcDataAccessLayer obj = new MandateRegInWardUnProcDataAccessLayer();
        [HttpGet]
        [Route("api/DownloadoldemandateUnProcInWard/BankBind/{UserId}/{EntityId}")]
        public Dictionary<string, object> BankBind(string UserId, string EntityId)
        {
            return obj.BankBind(UserId, EntityId);
        }

        [HttpGet]
        [Route("api/DownloadoldemandateUnProcInWard/GetUserCorpData/{EntityId}")]
        public Dictionary<string, object> GetUserCorpData(string EntityId)
        {
            return obj.GetUserCorpData(EntityId);
        }
        //[HttpPost]
        //[Route("api/Downloadoldemandate/Searchdata")]
        //public IEnumerable<Searchdata>Searchdata([FormData]Searchdata objsearch)
        //{
        //    return obj.SearchData(objsearch);
        //}

        [HttpGet]
        [Route("api/DownloadoldemandateUnProcInWard/SearchData/{FromDate}/{ToDate}/{Bank}/{UserId}/{EntityId}/{Reference}/{ActivityID}")]
        public IEnumerable<UnderProcessMandatesInWard> SearchData(string FromDate, string ToDate, string Bank, string UserId, string EntityId, string Reference, string ActivityID)
        {
            return obj.SearchData(FromDate, ToDate, Bank, UserId, EntityId, Reference, ActivityID);
        }
    }
}