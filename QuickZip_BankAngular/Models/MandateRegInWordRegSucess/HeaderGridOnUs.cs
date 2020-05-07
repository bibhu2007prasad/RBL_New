using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZip_BankAngular.Models
{
    public class HeaderGridOnUs
    {
        public Int32 Sno { get; set; }
        public string LOTNO { get; set; }
        public string ProcessDate { get; set; }
        public Int32 TotalCount { get; set; }
        public string CreatedOn { get; set; }
        public string UserName { get; set; }
        public string RESAcceptedRejected { get; set; }
        public string REJECTREASON { get; set; }
    }
}