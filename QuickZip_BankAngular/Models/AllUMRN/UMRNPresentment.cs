using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZip_BankAngular.Models
{
    public class UMRNPresentment
    {
        //public Int64 Sno { get; set; }
        //public string UMRN { get; set; }
        //public string Amount { get; set; }
        //public string Refrence { get; set; }
        //public string PresentmentDate { get; set; }
        //public Int32 type { get; set; }
        //public string FileNo { get; set; }
        //public string customer1 { get; set; }
        //public string UserId { get; set; }
        //public string EntityId { get; set; }




        public Int64 Sno { get; set; }
        public string UMRN { get; set; }
        public string Amount { get; set; }
        public string Refrence { get; set; }
        public string CustomerName { get; set; }       
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string Status { get; set; }
        
    }
}