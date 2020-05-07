﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZip_BankAngular.Models
{
    public class AllUMRN
    {
        public Int64 Sno { get; set; }
        public string UMRN { get; set; }
        public string CustomerName { get; set; }
        public string Refrence { get; set; }
        public decimal Amount { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string CreatedOn { get; set; }
        public string RecordType { get; set; }
        public string EntityId { get; set; }
    }
}