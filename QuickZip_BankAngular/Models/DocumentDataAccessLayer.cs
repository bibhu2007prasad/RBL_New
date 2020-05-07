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
    public class DocumentDataAccessLayer
    {
        //AngularTestdatabaseEntities context = new AngularTestdatabaseEntities();
        Demo2_ZipNach_RBLBank_AngularEntities context = new Demo2_ZipNach_RBLBank_AngularEntities();
        List<Document> dataList = new List<Document>();

        //For Temporary Bibhu start
        //string EntityId = "1";
        //string UserId = "3";
        //For Temporary Bibhu end
        public Dictionary<string, object> GetAllDocuments(string UserId, string EntityId)
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_Master]").With<Document>().Execute("@QueryType", "@UserId", "@EntityId", "BindGrid_DocumentType", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%")))));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //To Add new employee record 
        public IEnumerable<Document> AddDocument(Document Document, string UserId, string EntityId)
        {
            try
            {
                string isDeleted = "0";
                string isActive = (Document.IsActive == "true") ? "1" : "0";

                var Result = context.MultipleResults("[dbo].[Sp_Master]").With<Document>().Execute("@QueryType", "@DocumentCode", "@DocumentName", "@UserId", "@EntityId", "@IsActive", "SaveData_DocumentType", Document.DocumentCode, Document.DocumentName, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%"))), isActive);
                foreach (var _holiday in Result)
                {
                    //Flag = employe.Cast<ResFlag>().ToList() .Select(x=>x.Responseflag).First().ToString();
                    dataList = _holiday.Cast<Document>().ToList();
                }
                return dataList;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        ////To Delete the record on a particular employee
        //public IEnumerable<Document> DeleteDocument(int id)
        //{
        //    try
        //    {
        //        var Result = context.MultipleResults("[dbo].[Sp_Master]").With<Document>().Execute("@QueryType", "@UserId", "@EntityId", "@HolidayID", "DeleteHoliday_HolidayMaster", UserId, EntityId, id.ToString());
        //        foreach (var _holiday in Result)
        //        {
        //            dataList = _holiday.Cast<Document>().ToList();
        //        }
        //        return dataList;
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}


        //To Update new employee record 
        public IEnumerable<Document> EditDocument(Document Document, string UserId, string EntityId, int id)
        {
            try
            {
                //string isDeleted = "0";
                string isActive = (Document.IsActive == "true") ? "1" : "0";
                var Result = context.MultipleResults("[dbo].[Sp_Master]").With<Document>().Execute("@QueryType", "@DocumentCode", "@DocumentName", "@UserId", "@EntityId", "@IsActive", "@DocumentTypeid", "UpdateData_DocumentType", Document.DocumentCode, Document.DocumentName, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%"))), isActive,Convert.ToString(id));
                foreach (var _holiday in Result)
                {
                    dataList = _holiday.Cast<Document>().ToList();
                }
                return dataList;
            }
            catch
            {
                throw;
            }
        }

    }


}