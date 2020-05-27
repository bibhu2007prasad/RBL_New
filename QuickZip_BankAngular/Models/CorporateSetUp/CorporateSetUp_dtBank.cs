using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZip_BankAngular.Models
{
    public class CorporateSetUp_dtBank
    {
        public string SponsorBankName { get; set; }
        public string SponsorBankcode { get; set; }
        public string IFSC { get; set; }
        public string UtilityCode { get; set; }
        public string AccountNumber { get; set; }
        public IList<string> dtBankCode { get; set; }
    }
}