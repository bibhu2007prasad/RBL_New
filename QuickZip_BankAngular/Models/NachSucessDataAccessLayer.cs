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
    public class NachSucessDataAccessLayer
    {
        //AngularTestdatabaseEntities context = new AngularTestdatabaseEntities();
        Demo2_ZipNach_RBLBank_AngularEntities dbcontext = new Demo2_ZipNach_RBLBank_AngularEntities();

        //For Temporary Bibhu end
        public Dictionary<string, object> GetAllHeader(string UserId, string EntityId, string Status)
        {
            try
            {
                //EntityId = DbSecurity.Encrypt(HttpContext.Current.Server.UrlDecode(EntityId));
                //UserId = DbSecurity.Encrypt(HttpContext.Current.Server.UrlDecode(UserId));
                //var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[SP_GeneraateMandateRegFile]").With<HeaderGrid>().Execute("@QueryType", "@UserId", "@EntityId", "@Status", "BindHeaderGrid_Regsuccess", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%"))) , DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%")))),Status);
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_UMRNPresentment]").With<HeaderGridNachSuccess>().Execute("@QueryType", "@UserId", "@EntityId", "@Status", "Presentment_StatusUpload_Header", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%"))), Status));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> GetAllDetails(string UserId, string EntityId, string Status, string FileNo, string UploadID)
        {
            try
            {
                //EntityId = DbSecurity.Encrypt(HttpContext.Current.Server.UrlDecode(EntityId));
                //UserId = DbSecurity.Encrypt(HttpContext.Current.Server.UrlDecode(UserId));
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_UMRNPresentment]").With<DetailsGridNachSuccess>().Execute("@QueryType", "@UserId", "@EntityId", "@Status", "@Fileno", "@UploadHeaderId1", "Presentment_StatusUpload_Detail", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%"))), Status, FileNo, UploadID));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }


}