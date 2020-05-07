using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZip_BankAngular.Models
{
    public class RegionMaster
    {
        public Int64 Sno { get; set; }
        public Int64 RegionID { get; set; }
        public string RegionCode { get; set; }
        public string RegionName { get; set; }
        public string StateName { get; set; }
        public string StateIDs { get; set; }
        public Int64 EntityID { get; set; }

        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedOn { get; set; }
        public string IsActive { get; set; }
        public string IsDeleted { get; set; }
    }
}