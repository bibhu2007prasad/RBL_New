using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZip_BankAngular.Models
{
    public class ReturnRegionMaster
    {

        public Int64 ReasonID { get; set; }
        public Int64 Sno { get; set; }
        public string ReasonCode { get; set; }
        public string ReturnReason { get; set; }
        public string Description { get; set; }
        public Int64 EntityId { get; set; }

        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedOn { get; set; }
        public string IsActive { get; set; }
        public string IsDeleted { get; set; }
    }
}