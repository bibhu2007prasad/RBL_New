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
    public class BusinessSegmentDataAccessLayer
    {
    //AngularTestdatabaseEntities context = new AngularTestdatabaseEntities();
        Demo2_ZipNach_RBLBank_AngularEntities context = new Demo2_ZipNach_RBLBank_AngularEntities();
        List<BusinessSegment> dataList = new List<BusinessSegment>();
       

        //For Temporary Bibhu start
        //string EntityId = "1";
        //string UserId = "3";
        //For Temporary Bibhu end


        public Dictionary<string, object> GetAllBusinessSegments(string UserId, string EntityId)
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_Master]").With<BusinessSegment>().Execute("@QueryType", "@UserId", "@EntityId", "BindGrid_BusinessSegment", UserId, EntityId));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //To Add new BusinessSegment record 
        public IEnumerable<BusinessSegment> AddBusinessSegment(BusinessSegment BusinessSegment, string UserId, string EntityId)
        {
            try
            {
                string password = string.Empty;
                string passwordKey = string.Empty;
                string PassW = Convert.ToString(ConfigurationManager.AppSettings["DefaultPswdUser"]);
                password = DbSecurity.Encrypt(PassW, ref passwordKey);
                string isDeleted = "0";
                string isActive = (BusinessSegment.IsActive == "true") ? "1" : "0";

                var Result = context.MultipleResults("[dbo].[Sp_Master]").With<BusinessSegment>().Execute("@QueryType", "@BusinessSegmentCode", "@BusinessSegmentName", "@BusinessSegmentDesc", "@UserId", "@EntityId", "@IsActive", "SaveData_BusinessSegment", BusinessSegment.BusinessSegmentCode, BusinessSegment.BusinessSegmentName,BusinessSegment.BusinessSegmentDesc, UserId, EntityId, isActive);
                foreach (var _holiday in Result)
                {
                    //Flag = employe.Cast<ResFlag>().ToList() .Select(x=>x.Responseflag).First().ToString();
                    dataList = _holiday.Cast<BusinessSegment>().ToList();
                }
                return dataList;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        ////To Delete the record on a particular BusinessSegment
        //public IEnumerable<BusinessSegment> DeleteDocument(int id)
        //{
        //    try
        //    {
        //        var Result = context.MultipleResults("[dbo].[Sp_Master]").With<BusinessSegment>().Execute("@QueryType", "@UserId", "@EntityId", "@HolidayID", "DeleteHoliday_HolidayMaster", UserId, EntityId, id.ToString());
        //        foreach (var _holiday in Result)
        //        {
        //            dataList = _holiday.Cast<BusinessSegment>().ToList();
        //        }
        //        return dataList;
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}


        //To Update new BusinessSegment record 
        public IEnumerable<BusinessSegment> EditBusinessSegment(BusinessSegment BusinessSegment, string UserId, string EntityId, int id)
        {
            try
            {
                string isDeleted = "0";
                string isActive = (BusinessSegment.IsActive == "true") ? "1" : "0";
                var Result = context.MultipleResults("[dbo].[Sp_Master]").With<BusinessSegment>().Execute("@QueryType", "@BusinessSegmentCode", "@BusinessSegmentName", "@BusinessSegmentDesc", "@UserId", "@EntityId", "@IsActive", "@BusinessSegmentID", "UpdateData_BusinessSegment", BusinessSegment.BusinessSegmentCode, BusinessSegment.BusinessSegmentName,BusinessSegment.BusinessSegmentDesc, UserId, EntityId, isActive, Convert.ToString(id));
                foreach (var _holiday in Result)
                {
                    dataList = _holiday.Cast<BusinessSegment>().ToList();
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