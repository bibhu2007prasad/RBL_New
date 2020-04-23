using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZip_BankAngular.Models
{
    public class BranchMaster
    {
        public Int64 Sno { get; set; }
        public Int64 BranchId { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
        public string IFSC { get; set; }

        public string Address { get; set; }
        public Int64 EntityId { get; set; }
        public Int64 StateId { get; set; }
        public string StateName { get; set; }
        public string MICR { get; set; }

        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public string IsDeleted { get; set; }
    }
}