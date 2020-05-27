﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuickZip_BankAngular.Models;
using System.Threading.Tasks;

namespace QuickZip_BankAngular.Controllers
{
    public class MandateRegOutWardProcessedController : ApiController
    {
        MandateRegOutWardProcDataAccessLayer obj = new MandateRegOutWardProcDataAccessLayer();
        [HttpGet]
        [Route("api/DownloadoldemandateProcOutWard/BankBind/{UserId}/{EntityId}")]
        public Dictionary<string, object> BankBind(string UserId, string EntityId)
        {
            return obj.BankBind(UserId, EntityId);
        }

        [HttpGet]
        [Route("api/DownloadoldemandateProcOutWard/GetUserCorpData/{EntityId}")]
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
        [Route("api/DownloadoldemandateProcOutWard/SearchData/{FromDate}/{ToDate}/{Bank}/{UserId}/{EntityId}/{Reference}/{ActivityID}")]
        public IEnumerable<ProcessMandatesOutWard> SearchData(string FromDate, string ToDate, string Bank, string UserId, string EntityId, string Reference, string ActivityID)
        {
            return obj.SearchData(FromDate, ToDate, Bank, UserId, EntityId, Reference, ActivityID);
        }
    }
}