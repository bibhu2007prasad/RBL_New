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
    public class RegionMasterDataAccessLayer
    {
        //AngularTestdatabaseEntities context = new AngularTestdatabaseEntities();
        Demo2_ZipNach_RBLBank_AngularEntities context = new Demo2_ZipNach_RBLBank_AngularEntities();
        List<RegionMaster> dataList = new List<RegionMaster>();


        //For Temporary Bibhu start
        //string EntityId = "1";
        //string UserId = "3";
        //For Temporary Bibhu end

        public Dictionary<string, object> BindStates(string UserId, string EntityId)
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_Master]").With<State>().Execute("@QueryType", "@UserId", "@EntityId", "BindState_BranchMaster", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%")))));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Dictionary<string, object> GetAllRegionMasters(string UserId, string EntityId)
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_Master]").With<RegionMaster>().Execute("@QueryType", "@UserId", "@EntityId", "BindRegion_RegionMaster", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%")))));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //To Add new RegionMaster record 
        public IEnumerable<RegionMaster> AddRegionMaster(RegionMaster RegionMaster, string UserId, string EntityId)
        {
            try
            {

                string isDeleted = "0";
                string isActive = (RegionMaster.IsActive == "true") ? "1" : "0";
                //string isActive = (RegionMaster.IsActive == true) ? "1" : "0";

                var Result = context.MultipleResults("[dbo].[Sp_Master]").With<RegionMaster>().Execute("@QueryType", "@RegionCode", "@RegionName", "@UserId", "@EntityId", "@StateIDs", "@ISActive", "SaveRegion_RegionMaster", RegionMaster.RegionCode, RegionMaster.RegionName, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%"))), RegionMaster.StateIDs, isActive);
                foreach (var _holiday in Result)
                {
                    //Flag = employe.Cast<ResFlag>().ToList() .Select(x=>x.Responseflag).First().ToString();
                    dataList = _holiday.Cast<RegionMaster>().ToList();
                }
                return dataList;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        ////To Delete the record on a particular RegionMaster
        //public IEnumerable<RegionMaster> DeleteDocument(int id)
        //{
        //    try
        //    {
        //        var Result = context.MultipleResults("[dbo].[Sp_Master]").With<RegionMaster>().Execute("@QueryType", "@UserId", "@EntityId", "@HolidayID", "DeleteHoliday_HolidayMaster", UserId, EntityId, id.ToString());
        //        foreach (var _holiday in Result)
        //        {
        //            dataList = _holiday.Cast<RegionMaster>().ToList();
        //        }
        //        return dataList;
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}


        //To Update new RegionMaster record 
        public IEnumerable<RegionMaster> EditRegionMaster(RegionMaster RegionMaster, string UserId, string EntityId, int id)
        {
            try
            {
                string isDeleted = "0";
                string isActive = (RegionMaster.IsActive == "true") ? "1" : "0";
                // string isActive = (RegionMaster.IsActive == true) ? "1" : "0";
                var Result = context.MultipleResults("[dbo].[Sp_Master]").With<RegionMaster>().Execute("@QueryType", "@RegionCode", "@RegionName", "@UserId", "@EntityId", "@RegionID", "@StateIDs", "@ISActive", "UpdateRegion_RegionMaster", RegionMaster.RegionCode, RegionMaster.RegionName, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%"))), Convert.ToString(id),RegionMaster.StateIDs,isActive);
                foreach (var _holiday in Result)
                {
                    dataList = _holiday.Cast<RegionMaster>().ToList();
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