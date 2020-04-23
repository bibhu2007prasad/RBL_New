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
    public class EmployeeDataAccessLayer
    {
        //AngularTestdatabaseEntities context = new AngularTestdatabaseEntities();
        Demo2_ZipNach_RBLBank_AngularEntities context = new Demo2_ZipNach_RBLBank_AngularEntities();
        List<Employee> dataList = new List<Employee>();

        //For Temporary Bibhu start
        //string EntityId = "1";
        //string UserId = "3";
        //For Temporary Bibhu end
        public Dictionary<string, object> BindDesignation(string UserId, string EntityId)
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_RMMaster]").With<DDDesignation>().Execute("@QueryType", "@UserId", "@EntityId", "BindDesignation", UserId, EntityId));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> GetAllEmployees(string UserId, string EntityId)
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_RMMaster]").With<Employee>().Execute("@QueryType", "@UserId", "@EntityId", "BindGrid", UserId, EntityId));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //To Add new employee record 
        public IEnumerable<Employee> AddEmployee(Employee employee, string UserId, string EntityId)
        {
            try
            {
                string password = string.Empty;
                string passwordKey = string.Empty;
                string PassW = Convert.ToString(ConfigurationManager.AppSettings["DefaultPswdUser"]);
                password = DbSecurity.Encrypt(PassW, ref passwordKey);
                string isDeleted = "0";
                string isActive = (employee.IsActive == "true") ? "1" : "0";

                var Result = context.MultipleResults("[dbo].[Sp_RMMaster]").With<Employee>().Execute("@QueryType", "@RM_Code", "@RM_Name", "@UserId", "@EntityId", "@Mobile", "@Email", "@password", "@passwordKey", "@IsActive", "@IsDeleted", "@Designation", "Insertdata", employee.Emp_Code, employee.Emp_Name, UserId, EntityId,employee.PhoneNo, employee.EmailId,password, passwordKey,isActive,isDeleted,Convert.ToString(employee.DesignationId));
                foreach (var _holiday in Result)
                {
                    //Flag = employe.Cast<ResFlag>().ToList() .Select(x=>x.Responseflag).First().ToString();
                    dataList = _holiday.Cast<Employee>().ToList();
                }
                return dataList;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        ////To Delete the record on a particular employee
        //public IEnumerable<Employee> DeleteDocument(int id)
        //{
        //    try
        //    {
        //        var Result = context.MultipleResults("[dbo].[Sp_Master]").With<Employee>().Execute("@QueryType", "@UserId", "@EntityId", "@HolidayID", "DeleteHoliday_HolidayMaster", UserId, EntityId, id.ToString());
        //        foreach (var _holiday in Result)
        //        {
        //            dataList = _holiday.Cast<Employee>().ToList();
        //        }
        //        return dataList;
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}


        //To Update new employee record 
        public IEnumerable<Employee> EditEmployee(Employee employee, string UserId, string EntityId, int id)
        {
            try
            {
                string isDeleted = "0";
                string isActive = (employee.IsActive == "true") ? "1" : "0";
                var Result = context.MultipleResults("[dbo].[Sp_RMMaster]").With<Employee>().Execute( "@QueryType", "@RM_Code", "@RM_Name", "@UserId", "@EntityId", "@RM_Id", "@Mobile", "@Email", "@IsActive", "@IsDeleted", "@Designation", "UpdateData", employee.Emp_Code, employee.Emp_Name,UserId, EntityId, Convert.ToString(id), employee.PhoneNo, employee.EmailId, isActive, isDeleted,Convert.ToString(employee.DesignationId));
                foreach (var _holiday in Result)
                {
                    dataList = _holiday.Cast<Employee>().ToList();
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