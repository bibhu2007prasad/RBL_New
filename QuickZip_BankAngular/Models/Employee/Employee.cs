using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZip_BankAngular.Models
{
    public class Employee
    {
        public Int64 EmpId { get; set; }
        public string Emp_Code { get; set; }
        public string Emp_Name { get; set; }
        public Int32 UserID { get; set; }

        public string DesignationName { get; set; }
        public Int64 DesignationId { get; set; }
        public string EmailId { get; set; }
        public string PhoneNo { get; set; }



        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedOn { get; set; }
        public string IsActive { get; set; }
        public string IsDeleted { get; set; }
    }
}