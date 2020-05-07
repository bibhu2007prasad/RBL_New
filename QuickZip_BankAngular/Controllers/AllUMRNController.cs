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
    public class AllUMRNController : ApiController
    {
        AllUMRNDataAccessLayer objAllUMRN = new AllUMRNDataAccessLayer();

        [HttpGet]
        [Route("api/AllUMRN/BindGridDetails/{UMRN}/{EntityId}")]
        public Dictionary<string, object> BindGridDetails(string UMRN, string EntityId)
        {
            return objAllUMRN.BindGridDetails(UMRN, EntityId);
        }

        [HttpGet]
        [Route("api/AllUMRN/BindSearch/{UMRN}/{Customer}/{Reference}/{EntityId}")]
        public Dictionary<string, object> BindSearch(string UMRN,string Customer,string Reference, string EntityId)
        {
            return objAllUMRN.BindSearch(UMRN,Customer,Reference,EntityId);
        }

        [HttpGet]
        [Route("api/AllUMRN/Index/{topVal}/{EntityId}")]
        public Dictionary<string, object> Index(string topVal, string EntityId)
        {
            return objAllUMRN.GetAllAllUMRNs(topVal, EntityId);
        }

        [HttpPost]
        [Route("api/AllUMRN/Create/{UserId}/{EntityId}")]
        public IEnumerable<LegacyDetails> Create([FromBody] LegacyDetails legacyDetails, string UserId, string EntityId)
        {
            return objAllUMRN.AddLegacyDetails(legacyDetails, UserId, EntityId);
        }


    }
}