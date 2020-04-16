﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using BusinessLibrary;
using QuickZip_BankAngular.Entity;
using System.Threading.Tasks;

namespace QuickZip_BankAngular.Models
{
    public class DesignationDataAccessLayer
    {
        //AngularTestdatabaseEntities context = new AngularTestdatabaseEntities();
        Demo2_ZipNach_RBLBank_AngularEntities context = new Demo2_ZipNach_RBLBank_AngularEntities();
        List<Designation> dataList = new List<Designation>();

        //For Temporary Bibhu start
        string EntityId = "1";
        string UserId = "3";
        //For Temporary Bibhu end
        public Dictionary<string, object> GetAllDesignations()
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_Master]").With<Designation>().Execute("@QueryType", "@UserId", "@EntityId", "BindGrid_Designation", EntityId, UserId));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //To Add new employee record 
        public IEnumerable<Designation> AddDesignation(Designation Designation)
        {
            try
            {
                string isDeleted = "0";
                var Result = context.MultipleResults("[dbo].[Sp_Master]").With<Designation>().Execute("@QueryType", "@QueryType", "@DesignationCode", "@DesignationName", "@IsActive", "@IsDeleted", "@UserId", "@EntityId", "SaveDesignation_Master", Designation.DesignationCode, Designation.DesignationName, Designation.IsActive, isDeleted, UserId, EntityId);
                foreach (var _holiday in Result)
                {
                    //Flag = employe.Cast<ResFlag>().ToList() .Select(x=>x.Responseflag).First().ToString();
                    dataList = _holiday.Cast<Designation>().ToList();
                }
                return dataList;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //To Delete the record on a particular employee
        public IEnumerable<Designation> DeleteDesignation(int id)
        {
            try
            {
                var Result = context.MultipleResults("[dbo].[Sp_Master]").With<Designation>().Execute("@QueryType", "@UserId", "@EntityId", "@HolidayID", "DeleteHoliday_HolidayMaster", UserId, EntityId, id.ToString());
                foreach (var _holiday in Result)
                {
                    dataList = _holiday.Cast<Designation>().ToList();
                }
                return dataList;
            }
            catch
            {
                throw;
            }
        }


        //To Update new employee record 
        public IEnumerable<Designation> EditDesignation(Designation Designation, int id)
        {
            try
            {
                var Result = context.MultipleResults("[dbo].[Sp_Master]").With<Designation>().Execute("@QueryType", "@DesignationID", "@DesignationCode", "@DesignationName", "@IsActive", "@IsDeleted", "@UserId", "@EntityId", "UpdateDesignation_Master", id.ToString(), Designation.DesignationCode,Designation.DesignationName,Designation.IsActive,Designation.IsDeleted, UserId, EntityId);
                foreach (var _holiday in Result)
                {
                    dataList = _holiday.Cast<Designation>().ToList();
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