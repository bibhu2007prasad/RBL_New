﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuickZip_BankAngular.Models;
using System.Threading.Tasks;

namespace QuickZip_BankAngular.Controllers
{
    public class MandateRegOutWordRegSucessController : ApiController
    {
        MandateRegSuccessDataAccessLayer objMandateRegSuccess = new MandateRegSuccessDataAccessLayer();

        [HttpGet]
        // [Route("api/NachMandate/Binddetails")]
        [Route("api/MandateRegOutWord/GetAllHeader/{UserId}/{EntityId}/{Status}")]
        public Dictionary<string, object> GetAllHeader(string UserId, string EntityId, string Status)
        {
            return objMandateRegSuccess.GetAllHeader(UserId, EntityId,Status);
        }

        [HttpGet]
        // [Route("api/NachMandate/Binddetails")]
        [Route("api/MandateRegOutWord/GetAllDetails/{UserId}/{EntityId}/{Status}/{LotNo}")]
        public Dictionary<string, object> GetAllDetails(string UserId, string EntityId, string Status, string LotNo)
        {
            return objMandateRegSuccess.GetAllDetails(UserId, EntityId, Status,LotNo);
        }


    }
}