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
    public class BranchMasterDataAccessLayer
    {
        //AngularTestdatabaseEntities context = new AngularTestdatabaseEntities();
        Demo2_ZipNach_RBLBank_AngularEntities context = new Demo2_ZipNach_RBLBank_AngularEntities();
        List<BranchMaster> dataList = new List<BranchMaster>();

        //For Temporary Bibhu start
        //string EntityId = "1";
        //string UserId = "3";
        //For Temporary Bibhu end
        public Dictionary<string, object> BindStates(string UserId, string EntityId)
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_Master]").With<State>().Execute("@QueryType", "@UserId", "@EntityId", "BindState_BranchMaster", UserId, EntityId));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> GetAllBranchMasters(string UserId, string EntityId)
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_Master]").With<BranchMaster>().Execute("@QueryType", "@UserId", "@EntityId", "BindGrid_BranchMaster", UserId, EntityId));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //To Add new branchMaster record 
        public IEnumerable<BranchMaster> AddBranchMaster(BranchMaster branchMaster, string UserId, string EntityId)
        {
            try
            {
                string isDeleted = "0";
                //string isActive = (branchMaster.IsActive == "true") ? "1" : "0";

                string isActive = (branchMaster.IsActive == true) ? "1" : "0";

                var Result = context.MultipleResults("[dbo].[Sp_Master]").With<BranchMaster>().Execute("@QueryType", "@branchcode", "@branchname", "@branchifsc", "@branchaddr", "@UserId", "@EntityId", "@IsActive", "@state", "@Micr", "SaveData_BranchMaster", branchMaster.BranchCode, branchMaster.BranchName,branchMaster.IFSC,branchMaster.Address, UserId, EntityId, isActive, Convert.ToString(branchMaster.StateId),branchMaster.MICR);
                foreach (var _holiday in Result)
                {
                    //Flag = employe.Cast<ResFlag>().ToList() .Select(x=>x.Responseflag).First().ToString();
                    dataList = _holiday.Cast<BranchMaster>().ToList();
                }
                return dataList;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        ////To Delete the record on a particular branchMaster
        //public IEnumerable<BranchMaster> DeleteDocument(int id)
        //{
        //    try
        //    {
        //        var Result = context.MultipleResults("[dbo].[Sp_Master]").With<BranchMaster>().Execute("@QueryType", "@UserId", "@EntityId", "@HolidayID", "DeleteHoliday_HolidayMaster", UserId, EntityId, id.ToString());
        //        foreach (var _holiday in Result)
        //        {
        //            dataList = _holiday.Cast<BranchMaster>().ToList();
        //        }
        //        return dataList;
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}


        //To Update new branchMaster record 
        public IEnumerable<BranchMaster> EditBranchMaster(BranchMaster branchMaster, string UserId, string EntityId, int id)
        {
            try
            {
                string isDeleted = "0";
                //string isActive = (branchMaster.IsActive == "true") ? "1" : "0";

                string isActive = (branchMaster.IsActive == true) ? "1" : "0";
                var Result = context.MultipleResults("[dbo].[Sp_Master]").With<BranchMaster>().Execute("@QueryType", "@branchcode", "@branchname", "@branchifsc", "@branchaddr", "@UserId", "@EntityId", "@branchid", "@IsActive", "@state", "@Micr", "UpdateData_BranchMaster", branchMaster.BranchCode, branchMaster.BranchName,branchMaster.IFSC,branchMaster.Address, UserId, EntityId, Convert.ToString(id), isActive, Convert.ToString(branchMaster.StateId), branchMaster.MICR);
                foreach (var _holiday in Result)
                {
                    dataList = _holiday.Cast<BranchMaster>().ToList();
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