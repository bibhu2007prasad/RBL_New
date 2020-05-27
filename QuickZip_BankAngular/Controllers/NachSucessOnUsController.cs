using System;
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
    public class NachSucessOnUsController : ApiController
    {
        NachSucessOnUsDataAccessLayer objNachSucessOnUs = new NachSucessOnUsDataAccessLayer();

        [HttpGet]
        // [Route("api/NachMandate/Binddetails")]
        [Route("api/NachSucessOnUs/GetAllHeader/{UserId}/{EntityId}/{Status}")]
        public Dictionary<string, object> GetAllHeader(string UserId, string EntityId, string Status)
        {
            return objNachSucessOnUs.GetAllHeader(UserId, EntityId, Status);
        }

        [HttpGet]
        // [Route("api/NachMandate/Binddetails")]
        [Route("api/NachSucessOnUs/GetAllDetails/{UserId}/{EntityId}/{Status}/{FileNo}/{UploadID}")]
        public Dictionary<string, object> GetAllDetails(string UserId, string EntityId, string Status, string FileNo,string UploadID)
        {
            return objNachSucessOnUs.GetAllDetails(UserId, EntityId, Status, FileNo, UploadID);
        }


    }
}