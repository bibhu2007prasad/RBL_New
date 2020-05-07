using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZip_BankAngular.Models
{
    public class LinkSetUp
    {
        public Int64 Srno { get; set; }
        public Int64 LinkID { get; set; }
        public string LinkName { get; set; }
        public string IconName { get; set; }
        public string url { get; set; }
        public string Purpose { get; set; }
        public Int32 OrderNo { get; set; }
        public bool IsActive { get; set; }
        public string CreatedOn { get; set; }
        public bool IsDefault { get; set; }
        public Int32 ParentMenuId { get; set; }
        public string Flag { get; set; }
    }
}