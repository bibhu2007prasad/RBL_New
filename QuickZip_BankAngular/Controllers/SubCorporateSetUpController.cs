using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuickZip_BankAngular.Models;

namespace QuickZip_BankAngular.Controllers
{
    public class SubCorporateSetUpController : ApiController
    {
        // GET: SubCorporateSetUp
        SubCorporateSetUpDataAccessLayer ESDA = new SubCorporateSetUpDataAccessLayer();
        [HttpGet]
        [Route("api/SubCorporateSetUp/BindUtility")]
        public Dictionary<string, object> BindUtility()
        {
            return ESDA.BindUtility();
        }

        [HttpGet]
        [Route("api/SubCorporateSetUp/BindCategoryWithRelated")]
        public Dictionary<string, object> BindCategoryWithRelated()
        {
            return ESDA.BindCategoryWithRelated();
        }

        [HttpGet]
        [Route("api/SubCorporateSetUp/BindCountryAndBank")]
        public Dictionary<string, object> BindCountryAndBankApi()
        {
            return ESDA.BindCountryAndBank();
        }
        [HttpGet]
        [Route("api/SubCorporateSetUp/BindGrid/{UserId}/{EntityId}")]
        public Dictionary<string, object> BingGridApi(string UserId, string EntityId)
        {
            return ESDA.BindGridDataAccess(UserId, EntityId);
        }

        [HttpGet]
        [Route("api/SubCorporateSetUp/EditEntity/{EntityId}")]
        public Dictionary<string, object> EditEntity(string EntityId)
        {
            return ESDA.EditEntity(EntityId);
        }

        [HttpPost]
        [Route("api/SubCorporateSetUp/SaveData/{EntityId}")]
        public Dictionary<string, object> SaveDataApi([FromBody] AllFieldOfForm allFieldOfForm, string EntityId)
        {
            return ESDA.SaveDataDataAccess(allFieldOfForm, EntityId);
        }
        //[HttpPost]
        //[Route("api/SaveData/{dtBankCode}/{XmlFileName}/{dtcontactperson}")]
        //public Dictionary<string, object> SaveDataApi([FromBody] AllFieldOfForm allFieldOfForm,CorporateSetUp_dtBank dtBankCode,CorporateSetUp_XmlFileName XmlFileName,CorporateSetUp_dtContactPerson dtcontactperson)
        //{
        //    return ESDA.SaveDataDataAccess(allFieldOfForm,dtBankCode,XmlFileName,dtcontactperson);
        //}


        [HttpGet]
        [Route("api/SubCorporateSetUp/BindState/{CountryId}")]
        public Dictionary<string, object> BindStateApi(string CountryId)
        {
            return ESDA.BindStateDataAccess(CountryId);
        }
        [HttpGet]
        [Route("api/SubCorporateSetUp/BindCity/{StateId}")]
        public Dictionary<string, object> BindCityApi(string StateId)
        {
            return ESDA.BindCityDataAccess(StateId);
        }


    }
}
