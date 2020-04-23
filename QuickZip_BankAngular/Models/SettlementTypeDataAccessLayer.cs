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
    public class SettlementTypeDataAccessLayer
    {
        //AngularTestdatabaseEntities context = new AngularTestdatabaseEntities();
        Demo2_ZipNach_RBLBank_AngularEntities context = new Demo2_ZipNach_RBLBank_AngularEntities();
        List<SettlementTypeM> dataList = new List<SettlementTypeM>();

        //For Temporary Bibhu start
        //string EntityId = "1";
        //string UserId = "3";
        //For Temporary Bibhu end
        public Dictionary<string, object> BindSettlementType(string UserId, string EntityId)
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_Master]").With<SettlementTypeM>().Execute("@QueryType", "@UserId", "@EntityId", "BindGrid_SettlementType", UserId, EntityId));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> GetAllSettlementTypes(string UserId, string EntityId)
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_Master]").With<SettlementTypeM>().Execute("@QueryType", "@UserId", "@EntityId", "BindGrid_SettlementType", UserId, EntityId));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //To Add new SettlementTypeM record 
        public IEnumerable<SettlementTypeM> AddSettlementType(SettlementTypeM SettlementTypeM, string UserId, string EntityId)
        {
            try
            {
                string password = string.Empty;
                string passwordKey = string.Empty;
                string PassW = Convert.ToString(ConfigurationManager.AppSettings["DefaultPswdUser"]);
                password = DbSecurity.Encrypt(PassW, ref passwordKey);
                string isDeleted = "0";
                string isActive = (SettlementTypeM.IsActive == "true") ? "1" : "0";

                var Result = context.MultipleResults("[dbo].[Sp_Master]").With<SettlementTypeM>().Execute("@QueryType", "@SettlementTypeCode", "@SettlementTypeName", "@SettlementTypeDesc", "@UserId", "@EntityId", "@IsActive", "SaveData_SettlementType", SettlementTypeM.SettlementCode, SettlementTypeM.SettlementType,SettlementTypeM.Description, UserId, EntityId, isActive);
                foreach (var _holiday in Result)
                {
                    //Flag = employe.Cast<ResFlag>().ToList() .Select(x=>x.Responseflag).First().ToString();
                    dataList = _holiday.Cast<SettlementTypeM>().ToList();
                }
                return dataList;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        ////To Delete the record on a particular SettlementTypeM
        //public IEnumerable<SettlementTypeM> DeleteDocument(int id)
        //{
        //    try
        //    {
        //        var Result = context.MultipleResults("[dbo].[Sp_Master]").With<SettlementTypeM>().Execute("@QueryType", "@UserId", "@EntityId", "@HolidayID", "DeleteHoliday_HolidayMaster", UserId, EntityId, id.ToString());
        //        foreach (var _holiday in Result)
        //        {
        //            dataList = _holiday.Cast<SettlementTypeM>().ToList();
        //        }
        //        return dataList;
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}


        //To Update new SettlementTypeM record 
        public IEnumerable<SettlementTypeM> EditSettlementType(SettlementTypeM SettlementTypeM, string UserId, string EntityId, int id)
        {
            try
            {
                string isDeleted = "0";
                string isActive = (SettlementTypeM.IsActive == "true") ? "1" : "0";
                var Result = context.MultipleResults("[dbo].[Sp_Master]").With<SettlementTypeM>().Execute("@QueryType", "@SettlementTypeCode", "@SettlementTypeName", "@SettlementTypeDesc", "@UserId", "@EntityId", "@IsActive", "@SettlementTypeID", "UpdateData_SettlementType", SettlementTypeM.SettlementCode, SettlementTypeM.SettlementType,SettlementTypeM.Description, UserId, EntityId, isActive, Convert.ToString(id));
                foreach (var _holiday in Result)
                {
                    dataList = _holiday.Cast<SettlementTypeM>().ToList();
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