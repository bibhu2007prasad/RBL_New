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
    public class ReturnRegionDataAccessLayer
    {
        //AngularTestdatabaseEntities context = new AngularTestdatabaseEntities();
        Demo2_ZipNach_RBLBank_AngularEntities context = new Demo2_ZipNach_RBLBank_AngularEntities();
        List<ReturnRegionMaster> dataList = new List<ReturnRegionMaster>();


        //For Temporary Bibhu start
        //string EntityId = "1";
        //string UserId = "3";
        //For Temporary Bibhu end


        public Dictionary<string, object> GetAllReturnRegionMasters(string UserId, string EntityId)
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_Master]").With<ReturnRegionMaster>().Execute("@QueryType", "@UserId", "@EntityId", "BindGrid_ReturnReason_Master", UserId, EntityId));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //To Add new ReturnRegionMaster record 
        public IEnumerable<ReturnRegionMaster> AddReturnRegionMaster(ReturnRegionMaster ReturnRegionMaster, string UserId, string EntityId)
        {
            try
            {
                
                string isDeleted = "0";
                 string isActive = (ReturnRegionMaster.IsActive == "true") ? "1" : "0";
                //string isActive = (ReturnRegionMaster.IsActive == true) ? "1" : "0";

                var Result = context.MultipleResults("[dbo].[Sp_Master]").With<ReturnRegionMaster>().Execute("@QueryType", "@ReasonCode", "@ReasonName", "@IsActive", "@IsDeleted", "@UserId", "@EntityId", "@Description", "SaveReturnReason_Master", ReturnRegionMaster.ReasonCode, ReturnRegionMaster.ReturnReason,isActive,isDeleted, UserId, EntityId,  ReturnRegionMaster.Description);
                foreach (var _holiday in Result)
                {
                    //Flag = employe.Cast<ResFlag>().ToList() .Select(x=>x.Responseflag).First().ToString();
                    dataList = _holiday.Cast<ReturnRegionMaster>().ToList();
                }
                return dataList;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        ////To Delete the record on a particular ReturnRegionMaster
        //public IEnumerable<ReturnRegionMaster> DeleteDocument(int id)
        //{
        //    try
        //    {
        //        var Result = context.MultipleResults("[dbo].[Sp_Master]").With<ReturnRegionMaster>().Execute("@QueryType", "@UserId", "@EntityId", "@HolidayID", "DeleteHoliday_HolidayMaster", UserId, EntityId, id.ToString());
        //        foreach (var _holiday in Result)
        //        {
        //            dataList = _holiday.Cast<ReturnRegionMaster>().ToList();
        //        }
        //        return dataList;
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}


        //To Update new ReturnRegionMaster record 
        public IEnumerable<ReturnRegionMaster> EditReturnRegionMaster(ReturnRegionMaster ReturnRegionMaster, string UserId, string EntityId, int id)
        {
            try
            {
                string isDeleted = "0";
                string isActive = (ReturnRegionMaster.IsActive == "true") ? "1" : "0";
               // string isActive = (ReturnRegionMaster.IsActive == true) ? "1" : "0";
                var Result = context.MultipleResults("[dbo].[Sp_Master]").With<ReturnRegionMaster>().Execute("@QueryType", "@ReasonId", "@ReasonCode", "@ReasonName", "@IsActive", "@IsDeleted", "@UserId", "@EntityId", "@Description", "UpdateReturnReason_Master", Convert.ToString(id), ReturnRegionMaster.ReasonCode, ReturnRegionMaster.ReturnReason, isActive,isDeleted, UserId, EntityId,ReturnRegionMaster.Description);
                foreach (var _holiday in Result)
                {
                    dataList = _holiday.Cast<ReturnRegionMaster>().ToList();
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