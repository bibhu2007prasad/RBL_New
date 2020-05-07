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
    public class MandateRegSuccessDataAccessLayer
    {
        //AngularTestdatabaseEntities context = new AngularTestdatabaseEntities();
        Demo2_ZipNach_RBLBank_AngularEntities dbcontext = new Demo2_ZipNach_RBLBank_AngularEntities();
        List<Designation> dataList = new List<Designation>();

       
        //For Temporary Bibhu end
        public Dictionary<string, object> GetAllHeader(string UserId,string EntityId, string Status)
        {
            try
            {
                //EntityId = DbSecurity.Encrypt(HttpContext.Current.Server.UrlDecode(EntityId));
                //UserId = DbSecurity.Encrypt(HttpContext.Current.Server.UrlDecode(UserId));
                //var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[SP_GeneraateMandateRegFile]").With<HeaderGrid>().Execute("@QueryType", "@UserId", "@EntityId", "@Status", "BindHeaderGrid_Regsuccess", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%"))) , DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%")))),Status);
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[SP_GeneraateMandateRegFile]").With<HeaderGrid>().Execute("@QueryType", "@UserId", "@EntityId", "@Status", "BindHeaderGrid_Regsuccess", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%"))),Status));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> GetAllDetails(string UserId, string EntityId, string Status, string LotNo)
        {
            try
            {
                //EntityId = DbSecurity.Encrypt(HttpContext.Current.Server.UrlDecode(EntityId));
                //UserId = DbSecurity.Encrypt(HttpContext.Current.Server.UrlDecode(UserId));
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[SP_GeneraateMandateRegFile]").With<DetailGrid>().Execute("@QueryType", "@UserId", "@EntityId", "@Status", "@LotNo", "BindDetailsGrid_Regsuccess", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%"))), Status,LotNo));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }


}