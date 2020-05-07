using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Newtonsoft.Json;
using BusinessLibrary;
using QuickZip_BankAngular.Entity;
using System.Threading.Tasks;

namespace QuickZip_BankAngular.Models
{
    public class AllUMRNDataAccessLayer
    {
        //AngularTestdatabaseEntities context = new AngularTestdatabaseEntities();
        Demo2_ZipNach_RBLBank_AngularEntities context = new Demo2_ZipNach_RBLBank_AngularEntities();
        List<LegacyDetails> dataList = new List<LegacyDetails>();
        //List<AllUMRN> dataList1 = new List<AllUMRN>();

        //For Temporary Bibhu start
        //string EntityId = "1";
        //string UserId = "3";
        //For Temporary Bibhu end
        public Dictionary<string, object> BindGridDetails(string UMRN, string EntityId)
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_Presenment]").With<UMRNPresentment>().Execute("@QueryType", "@EntityId", "@UMRN", "EachUMRNHistoryDetails", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%"))), UMRN));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> BindSearch(string UMRN,string Customer,string Reference,string EntityId)
        {
            try
            {
                UMRN = (UMRN == "0" ? "" : UMRN);
                Reference = (Reference == "0" ? "" : Reference);
                Customer = (Customer == "0" ? "" : Customer);

                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_Uploaddata]").With<AllUMRN>().Execute("@QueryType", "@UMRN", "@CustomerName", "@Refrence", "@EntityID", "@topVal", "btnsearch_Click",UMRN,Customer,Reference, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%"))), "50"));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> GetAllAllUMRNs(string topVal, string EntityId)
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_Uploaddata]").With<AllUMRN>().Execute("@QueryType", "@topVal", "@EntityID", "UMRNUpload", topVal, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%")))));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //To Add new BusinessSegment record 
        public IEnumerable<LegacyDetails> AddLegacyDetails(LegacyDetails legacyDetails, string UserId, string EntityId)
        {
            try
            {
                string isDeleted = "0";
                string isActive = "1"; 

                var Result = context.MultipleResults("[dbo].[Sp_Uploaddata]").With<LegacyDetails>().Execute("@QueryType", "@UMRN", "@Refrence", "@Amount", "@FromDate", "@ToDate", "@CreatedBy", "@UserId", "@EntityId", "InsertData", legacyDetails.UMRN, legacyDetails.Refrence, Convert.ToString(legacyDetails.Amount),legacyDetails.FromDate,legacyDetails.ToDate,legacyDetails.CustomerName, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%"))));
                foreach (var _holiday in Result)
                {
                    //Flag = employe.Cast<ResFlag>().ToList() .Select(x=>x.Responseflag).First().ToString();
                    dataList = _holiday.Cast<LegacyDetails>().ToList();
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