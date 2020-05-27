using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZip_BankAngular.Models
{
    public class Table13
    {
        public Boolean Physical { get; set; }
        public Boolean NetBanking { get; set; }
        public Boolean Debit { get; set; }
        public Boolean Aadhar { get; set; }
        public Boolean ValidateByCustomer { get; set; }
        public Boolean ValidateByCooperate { get; set; }
        public Boolean PrintQR { get; set; }

        public Boolean PrintLogo { get; set; }
        public Boolean OCR { get; set; }
        public Boolean Customerphnumber { get; set; }
        public Boolean Customeremailid { get; set; }
        public Boolean NetValidateMail { get; set; }
        public Boolean NetManual { get; set; }
        public Boolean NetSMS { get; set; }

        public Boolean DebitValidateMail { get; set; }
        public Boolean DebitManual { get; set; }
        public Boolean DebitSMS { get; set; }
        public Boolean AadharValidateMail { get; set; }
        public Boolean AadharManual { get; set; }
        public Boolean AadharSMS { get; set; }
        public Boolean Emandate { get; set; }

        public Boolean IsAccountValidation { get; set; }
        public Boolean IsPresentment { get; set; }



        //public string categoryId { get; set; }
        //public string categorycode { get; set; }
        //public Int64 BankValidationUserCount { get; set; }
        //public Int64 AcValidationAdminCount { get; set; }
        //public Int64 AcValidationUserCount { get; set; }
        //public string ModeOfPayment { get; set; }
        //public string AmountBankMandate { get; set; }
    }
}