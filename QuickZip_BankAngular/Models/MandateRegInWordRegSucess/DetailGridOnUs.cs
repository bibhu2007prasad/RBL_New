using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZip_BankAngular.Models
{
    public class DetailGridOnUs
    {
        public Int32 Sno { get; set; }
        public string UMRN { get; set; }
        public Int64 MandateId { get; set; }
        public string ProcessDate { get; set; }
        public string Refrence1 { get; set; }
        public string CreatedOn { get; set; }
        public string RESAcceptedRejected { get; set; }
        public string REJECTREASON { get; set; }
    }
}