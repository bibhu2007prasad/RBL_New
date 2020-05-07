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
    public class HolidayDataAccessLayer
    {
        //AngularTestdatabaseEntities context = new AngularTestdatabaseEntities();
        Demo2_ZipNach_RBLBank_AngularEntities context = new Demo2_ZipNach_RBLBank_AngularEntities();
        List<Holiday> dataList = new List<Holiday>();

        //For Temporary Bibhu start
        //string EntityId = "1";
        //string UserId = "3";
        //For Temporary Bibhu end
        public Dictionary<string, object> GetAllHolidays(string UserId, string EntityId)
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_Master]").With<Holiday>().Execute("@QueryType", "@UserId", "@EntityId", "BindGrid_HolidayMaster", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%")))));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //To Add new employee record 
        public IEnumerable<Holiday> AddHoliday(Holiday holiday,string UserId,string EntityId)
        {
            try
            {
                var Result = context.MultipleResults("[dbo].[Sp_Master]").With<Holiday>().Execute("@QueryType", "@HolidayName", "@HolidayDate", "@UserId", "@EntityId", "SaveHoliday_HolidayMaster", holiday.HolidayName, Convert.ToString(holiday.HolidayDate), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%"))));
                foreach (var _holiday in Result)
                {
                    //Flag = employe.Cast<ResFlag>().ToList() .Select(x=>x.Responseflag).First().ToString();
                    dataList = _holiday.Cast<Holiday>().ToList();
                }
                return dataList;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //To Delete the record on a particular employee
        public IEnumerable<Holiday> DeleteHoliday(int id, string UserId, string EntityId)
        {
            try
            {
                var Result = context.MultipleResults("[dbo].[Sp_Master]").With<Holiday>().Execute("@QueryType", "@UserId", "@EntityId", "@HolidayID", "DeleteHoliday_HolidayMaster", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%"))), id.ToString());
                foreach (var _holiday in Result)
                {
                    dataList = _holiday.Cast<Holiday>().ToList();
                }
                return dataList;
            }
            catch
            {
                throw;
            }
        }


        //To Update new employee record 
        public IEnumerable<Holiday> EditHoliday(Holiday holiday, int id, string UserId, string EntityId)
        {
            try
            {
                var Result = context.MultipleResults("[dbo].[Sp_Master]").With<Holiday>().Execute("@QueryType", "@HolidayName", "@HolidayDate", "@UserId", "@EntityId", "@HolidayID", "Update_HolidayMaster", holiday.HolidayName, Convert.ToString(holiday.HolidayDate), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%"))), id.ToString());
                foreach (var _holiday in Result)
                {
                    dataList = _holiday.Cast<Holiday>().ToList();
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