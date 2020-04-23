using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZip_BankAngular.Models
{
    public class SettlementTypeM
    {
        public Int64 SettleMentTypeID { get; set; }
        public string SettlementCode { get; set; }
        public string SettlementType { get; set; }
        public string Description { get; set; }

        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedOn { get; set; }
        public string IsActive { get; set; }
        public string IsDeleted { get; set; }

    }
}