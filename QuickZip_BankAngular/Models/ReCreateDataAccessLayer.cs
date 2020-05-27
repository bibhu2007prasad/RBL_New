using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using BusinessLibrary;
using QuickZip_BankAngular.Entity;
using System.Threading.Tasks;

namespace QuickZip_BankAngular.Models
{
    public class ReCreateDataAccessLayer
    {
        Demo2_ZipNach_RBLBank_AngularEntities dbcontext = new Demo2_ZipNach_RBLBank_AngularEntities();
        List<MandateDetails> dataList = new List<MandateDetails>();
       
      
        public IEnumerable<MandateDetails> BindMandateDetails(string FromDate, string ToDate, string UserId, string EntityId, string MandateId,string Reference, string ActivityID)
        {
            try
            {
                MandateId = (MandateId == "0" ? "" : MandateId);
                Reference = (Reference == "0" ? "" : Reference);
                ActivityID = (ActivityID == "0" ? "" : ActivityID);

                var Result = dbcontext.MultipleResults("[dbo].[Sp_Mandate]").With<MandateDetails>().Execute("@QueryType", "@ToDate", "@FromDate", "@ActivityId", "@UserId", "@EntityId", "@Refrence1", "@MandateId", "BindMandateDetails", ToDate, FromDate,ActivityID, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%"))), Reference, MandateId);
                foreach (var data in Result)
                {
                    dataList = data.Cast<MandateDetails>().ToList();

                }
                return dataList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}