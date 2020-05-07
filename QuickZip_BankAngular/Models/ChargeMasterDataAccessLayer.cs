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
    public class ChargeMasterDataAccessLayer
    {
        //AngularTestdatabaseEntities context = new AngularTestdatabaseEntities();
        Demo2_ZipNach_RBLBank_AngularEntities context = new Demo2_ZipNach_RBLBank_AngularEntities();
        List<ChargeMaster> dataList = new List<ChargeMaster>();


        //For Temporary Bibhu start
        //string EntityId = "1";
        //string UserId = "3";
        //For Temporary Bibhu end


        public Dictionary<string, object> GetAllChargeMasters(string UserId, string EntityId)
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_Master]").With<ChargeMaster>().Execute("@QueryType", "@UserId", "@EntityId", "BindGrid_ChargeMaster", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%")))));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //To Add new ChargeMaster record 
        public IEnumerable<ChargeMaster> AddChargeMaster(ChargeMaster ChargeMaster, string UserId, string EntityId)
        {
            try
            {
                string isDeleted = "0";
                string isActive = (ChargeMaster.IsActive == "true") ? "1" : "0";
                string isDefault = (ChargeMaster.IsDefault == "true") ? "1" : "0";

                var Result = context.MultipleResults("[dbo].[Sp_Master]").With<ChargeMaster>().Execute("@QueryType", "@ChargemasterCode", "@ChargemasterName", "@ChargemasterDesc", "@UserId", "@EntityId", "@IsActive", "@IsDefault", "SaveData_Chargemaster", ChargeMaster.ChargeTypeCode, ChargeMaster.ChargeTypeName, ChargeMaster.ChargeTypeDesc, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%"))), isActive, isDefault);
                foreach (var _holiday in Result)
                {
                    //Flag = employe.Cast<ResFlag>().ToList() .Select(x=>x.Responseflag).First().ToString();
                    dataList = _holiday.Cast<ChargeMaster>().ToList();
                }
                return dataList;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        ////To Delete the record on a particular ChargeMaster
        //public IEnumerable<ChargeMaster> DeleteDocument(int id)
        //{
        //    try
        //    {
        //        var Result = context.MultipleResults("[dbo].[Sp_Master]").With<ChargeMaster>().Execute("@QueryType", "@UserId", "@EntityId", "@HolidayID", "DeleteHoliday_HolidayMaster", UserId, EntityId, id.ToString());
        //        foreach (var _holiday in Result)
        //        {
        //            dataList = _holiday.Cast<ChargeMaster>().ToList();
        //        }
        //        return dataList;
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}


        //To Update new ChargeMaster record 
        public IEnumerable<ChargeMaster> EditChargeMaster(ChargeMaster ChargeMaster, string UserId, string EntityId, int id)
        {
            try
            {
                string isDeleted = "0";
                string isActive = (ChargeMaster.IsActive == "true") ? "1" : "0";
                string isDefault = (ChargeMaster.IsDefault == "true") ? "1" : "0";
                var Result = context.MultipleResults("[dbo].[Sp_Master]").With<ChargeMaster>().Execute("@QueryType", "@ChargemasterCode", "@ChargemasterName", "@ChargemasterDesc", "@UserId", "@EntityId", "@IsActive", "@Chargemasterid", "@IsDefault", "UpdateData_Chargemaster", ChargeMaster.ChargeTypeCode, ChargeMaster.ChargeTypeName, ChargeMaster.ChargeTypeDesc, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%"))), isActive, Convert.ToString(id), isDefault);
                foreach (var _holiday in Result)
                {
                    dataList = _holiday.Cast<ChargeMaster>().ToList();
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