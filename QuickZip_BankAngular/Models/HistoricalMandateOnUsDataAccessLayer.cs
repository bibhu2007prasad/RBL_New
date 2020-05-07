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
    public class HistoricalMandateOnUsDataAccessLayer
    {
        Demo2_ZipNach_RBLBank_AngularEntities dbcontext = new Demo2_ZipNach_RBLBank_AngularEntities();
        List<HistoricalMandateOnUsClass> dataList = new List<HistoricalMandateOnUsClass>();
        List<Corporate> dataList_corp = new List<Corporate>();
        public Dictionary<string, object> BindCorp(string EntityId)
        {
            try
            {
                //string _EntityId = DbSecurity.Encrypt(HttpContext.Current.Server.UrlDecode(EntityId));
                //EntityId = DbSecurity.Encrypt(HttpContext.Current.Server.UrlDecode(EntityId));
                // UserId = DbSecurity.Encrypt(HttpContext.Current.Server.UrlDecode(UserId));
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_DownloadMandate]").With<CorporateOnUs>().Execute("@QueryType", "@EntityId", "BindCorporate", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%")))));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<HistoricalMandateOnUsClass> GetDataFromDB(string FromDate, string ToDate, string UserId, string EntityId, string Reference, string ActivityID)
        {
            try
            {
                //UserId = DbSecurity.Encrypt(HttpContext.Current.Server.UrlDecode(UserId));
                //string _EntityId = DbSecurity.Encrypt(HttpContext.Current.Server.UrlDecode(EntityId));

                EntityId = (EntityId == "0" ? "" : EntityId);
                Reference = (Reference == "0" ? "" : Reference);
                ActivityID = (ActivityID == "0" ? "" : ActivityID);

                var Result = dbcontext.MultipleResults("[dbo].[Sp_Mandate_OnUs]").With<HistoricalMandateOnUsClass>().Execute("@QueryType", "@ToDate"
       , "@FromDate", "@UserId", "@EntityId", "@Refrence1", "@ActivityName", "grdMandateDataDateWise_OnUs", ToDate, FromDate, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), EntityId, Reference, ActivityID);
                foreach (var HistoricalMandateData in Result)
                {
                    dataList = HistoricalMandateData.Cast<HistoricalMandateOnUsClass>().ToList();

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