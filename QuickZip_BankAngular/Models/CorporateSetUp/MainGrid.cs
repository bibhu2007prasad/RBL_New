using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZip_BankAngular.Models
{
    public class MainGrid
    {
        public Int64 Srno { get; set; }
        public Int64 EntityId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string SponsorBankName { get; set; }
        public string ParentBank { get; set; }
    }
}