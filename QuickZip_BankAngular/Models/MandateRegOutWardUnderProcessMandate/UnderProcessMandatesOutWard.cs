﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZip_BankAngular.Models
{
    public class UnderProcessMandatesOutWard
    {
        //public string sponsorbankcode { get; set; }
        //public string name { get; set; }
        public string IsMobileData { get; set; }//
        public string createdon { get; set; }//
        public string IsScan { get; set; }//
        public string JPGPath { get; set; }//
        public string TIPPath { get; set; }//
        public string IsPrint { get; set; }//
        public Int64 mandateid { get; set; }//
        
        public string BankName { get; set; }//
        //public string status { get; set; }
        public string Amount { get; set; }//
        public string IFSC { get; set; }
        public string Code { get; set; }//
        // public string BankName { get; set; }
        public string DateOnMandate { get; set; }//
        public string AcNo { get; set; }//
        public string Refrence1 { get; set; }//
        public string FromDate { get; set; }//
        public string Customer1 { get; set; }//
        public string debittype { get; set; }//
        public string Frequency { get; set; }//
        public string ToDebit { get; set; }//


        public string UMRN { get; set; }
        public string updatedon { get; set; }
        public string CreatedBy { get; set; }
        public string CorpName { get; set; }
    }
}