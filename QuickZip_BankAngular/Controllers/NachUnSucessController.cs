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
    public class NachUnSucessController : ApiController
    {
        NachUnSucessDataAccessLayer objNachUnSucess = new NachUnSucessDataAccessLayer();

        [HttpGet]
        // [Route("api/NachMandate/Binddetails")]
        [Route("api/NachUnSucess/GetAllHeader/{UserId}/{EntityId}/{Status}")]
        public Dictionary<string, object> GetAllHeader(string UserId, string EntityId, string Status)
        {
            return objNachUnSucess.GetAllHeader(UserId, EntityId, Status);
        }

        [HttpGet]
        // [Route("api/NachMandate/Binddetails")]
        [Route("api/NachUnSucess/GetAllDetails/{UserId}/{EntityId}/{Status}/{FileNo}/{UploadID}")]
        public Dictionary<string, object> GetAllDetails(string UserId, string EntityId, string Status, string FileNo, string UploadID)
        {
            return objNachUnSucess.GetAllDetails(UserId, EntityId, Status, FileNo, UploadID);
        }


    }
}