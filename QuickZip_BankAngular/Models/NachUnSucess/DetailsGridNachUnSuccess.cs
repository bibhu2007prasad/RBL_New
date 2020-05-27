using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZip_BankAngular.Models
{
    public class DetailsGridNachUnSuccess
    {
        public Int32 Sno { get; set; }
        public string FileNo { get; set; }
        public string UMRN { get; set; }
        public decimal Amount { get; set; }
        public string ReferenceNo { get; set; }
        public string ClientCode { get; set; }
        public string CorporateAcNo { get; set; }
        public string Status { get; set; }
        public string Reason { get; set; }
    }
}