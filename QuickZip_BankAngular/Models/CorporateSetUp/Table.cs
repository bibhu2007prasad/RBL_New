using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZip_BankAngular.Models
{
    public class Table
    {
        public Boolean ISTodateMandatoryEnach { get; set; }
        public Boolean IsZipShorABPS { get; set; }
        public Boolean IsAllowENachMobile { get; set; }
        public Boolean IsThirdTransaction { get; set; }
        public Boolean IsRefrence2Mandatory { get; set; }
        public Boolean IsEmandate { get; set; }
        public Boolean IsPhysical { get; set; }
        public Boolean IsShowMandateMode { get; set; }
        public Boolean IsSendEmailCustomer { get; set; }
        public Boolean IsRefrenceNumeric { get; set; }
        public Boolean IsValidationCountEnable { get; set; }
        public Int64 BankValidationAdminCount { get; set; }
        public Int64 BankValidationUserCount { get; set; }
        public Int64 AcValidationAdminCount { get; set; }
        public Int64 AcValidationUserCount { get; set; }
        public string ModeOfPayment { get; set; }
        public string AmountBankMandate { get; set; }
        public string InstructingMemberId { get; set; }
        public string PeriodType { get; set; }
        public string DebitType { get; set; }
        public string FrequencyType { get; set; }
        public string ToDebit { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string ContactPerson { get; set; }
        public string SponsorBankCode { get; set; }
        public string UtilityCode { get; set; }
        public string SponsorBankName { get; set; }
        public Boolean CheckerRequired { get; set; }
        public Boolean CheckerRecheck { get; set; }
        public Boolean IsNachPresentment { get; set; }
        public Int64 Reflength { get; set; }
        public string ReflengthType { get; set; }
    }
}