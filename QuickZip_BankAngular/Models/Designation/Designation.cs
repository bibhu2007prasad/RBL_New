using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZip_BankAngular.Models
{
    public class Designation
    {
        public Int64 Sno { get; set; }
        public Int64 DId { get; set; }
        public string DesignationCode { get; set; }
        public string DesignationName { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedOn { get; set; }
        public string IsActive { get; set; }
        public string IsDeleted { get; set; }
    }
}