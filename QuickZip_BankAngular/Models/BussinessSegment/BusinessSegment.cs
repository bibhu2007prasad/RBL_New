using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZip_BankAngular.Models
{
    public class BusinessSegment
    {
        public Int64 BusinessSegmentID { get; set; }
        public string BusinessSegmentCode { get; set; }
        public string BusinessSegmentName { get; set; }
        public string BusinessSegmentDesc { get; set; }
        public Int64 EntityID { get; set; }
        

        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedOn { get; set; }
        public string IsActive { get; set; }
        public string IsDeleted { get; set; }

       
    }
}