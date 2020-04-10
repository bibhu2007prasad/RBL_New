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
        AngularTestdatabaseEntities context = new AngularTestdatabaseEntities();
        List<Employee> dataList = new List<Employee>();
        public Dictionary<string, object> GetAllEmployees()
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[spGetAllEmployees]").With<Employee>().With<Student>().Execute("@QueryType", "BindEmployee"));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
      
        //To Add new employee record 
        public IEnumerable<Employee> AddEmployee(Employee employee)
        {
            try
            {
                var Result = context.MultipleResults("[dbo].[spAddEmployee]").With<Employee>().Execute("@QueryType", "@Name", "@Email", "@Password", "AddEmployee", employee.FullName, employee.Email, employee.Password);
                foreach (var employe in Result)
                {
                    //Flag = employe.Cast<ResFlag>().ToList() .Select(x=>x.Responseflag).First().ToString();
                    dataList = employe.Cast<Employee>().ToList();
                }
                return dataList;

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        //To Delete the record on a particular employee
        public IEnumerable<Employee> DeleteEmployee(int id)
        {
            try
            {
                var Result = context.MultipleResults("[dbo].[spDeleteEmployee]").With<Employee>().Execute("@QueryType", "@EmpId", "DelEmployee", id.ToString());
                foreach (var employe in Result)
                {
                    dataList = employe.Cast<Employee>().ToList();
                }
                return dataList;
            }
            catch
            {
                throw;
            }
        }


        //To Update new employee record 
        public IEnumerable<Employee> EditEmp(Employee employee,int id)
        {
            try
            {
                var Result = context.MultipleResults("[dbo].[spUpdateEmployee]").With<Employee>().Execute("@QueryType", "@Name", "@Email", "@Password", "@EmpId", "UpdateEmployee", employee.FullName, employee.Email, employee.Password,id.ToString());
                foreach (var employe in Result)
                {
                    dataList = employe.Cast<Employee>().ToList();
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