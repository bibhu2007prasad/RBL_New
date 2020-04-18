using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZip_BankAngular.Models
{
    public class Document
    {
        public Int64 EmpId { get; set; }
        public Int64 DocumentTypeid { get; set; }
        public string DocumentCode { get; set; }
        public string DocumentName { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedOn { get; set; }
        public string IsActive { get; set; }
        public string IsDeleted { get; set; }
    }
}