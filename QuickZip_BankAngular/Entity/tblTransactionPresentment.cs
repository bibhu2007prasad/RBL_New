//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuickZip_BankAngular.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblTransactionPresentment
    {
        public long PID { get; set; }
        public string FileNo { get; set; }
        public string BankName { get; set; }
        public string UMRN { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public long CreatedBy { get; set; }
        public long UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<long> TransheaderId { get; set; }
        public string ReferenceNo { get; set; }
        public string SponserBankCode { get; set; }
        public string UMRNStatus { get; set; }
        public Nullable<long> DetailSequence { get; set; }
        public string ReasonCode { get; set; }
        public string APIFileNo { get; set; }
        public string ClientCode { get; set; }
        public string CorporateAcNo { get; set; }
    }
}
