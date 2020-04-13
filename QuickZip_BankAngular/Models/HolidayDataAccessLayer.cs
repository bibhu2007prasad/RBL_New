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
        AngularTestdatabaseEntities context = new AngularTestdatabaseEntities();
        List<Holiday> dataList = new List<Holiday>();
        public Dictionary<string, object> GetAllHolidays()
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[spGetAllEmployees]").With<Holiday>().Execute("@QueryType", "BindEmployee"));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //To Add new employee record 
        public IEnumerable<Holiday> AddHoliday(Holiday holiday)
        {
            try
            {
                var Result = context.MultipleResults("[dbo].[spAddEmployee]").With<Holiday>().Execute("@QueryType", "@Name", "@Email", "@Password", "AddEmployee", holiday.HolidayName, holiday.Date);
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
        public IEnumerable<Holiday> DeleteHoliday(int id)
        {
            try
            {
                var Result = context.MultipleResults("[dbo].[spDeleteEmployee]").With<Holiday>().Execute("@QueryType", "@EmpId", "DelEmployee", id.ToString());
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
        public IEnumerable<Holiday> EditHoliday(Holiday holiday, int id)
        {
            try
            {
                var Result = context.MultipleResults("[dbo].[spUpdateEmployee]").With<Holiday>().Execute("@QueryType", "@Name", "@Email", "@Password", "@EmpId", "UpdateEmployee", holiday.HolidayName, holiday.Date, id.ToString());
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