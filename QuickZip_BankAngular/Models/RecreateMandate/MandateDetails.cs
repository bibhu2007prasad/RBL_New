using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZip_BankAngular.Models
{
    public class MandateDetails
    {
        public Int64 Srno { get; set; }
        public string ActivityName { get; set; }
        public string MandateId { get; set; }//
        public string Refrence1 { get; set; }//
        public string PhoneNumber { get; set; }//
        public string Customer1 { get; set; }//
        public string EmailId { get; set; }//
        public string RejectedReason { get; set; }//
        public string CreatedOn { get; set; }//

        public string Recreate_MandateId { get; set; }//
        public string Name { get; set; }
       
    }
}