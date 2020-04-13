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
    
    public partial class TblBankBulkUploadData
    {
        public long BankBulkUploadID { get; set; }
        public string ExlUploadedID { get; set; }
        public string DateOnMandate { get; set; }
        public string SponsorBank { get; set; }
        public string Utilitycode { get; set; }
        public string IWehereby { get; set; }
        public string ToDebit { get; set; }
        public string BankACNumber { get; set; }
        public string BankName { get; set; }
        public string IFSC { get; set; }
        public string OrMICR { get; set; }
        public string Amount { get; set; }
        public string Frequency { get; set; }
        public string DebitType { get; set; }
        public string RefNo1 { get; set; }
        public string RefNo2 { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailID { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string NameAsBankRrds1 { get; set; }
        public string NameAsBankRrds2 { get; set; }
        public string NameAsBankRrds3 { get; set; }
        public string EntityId { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<long> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdateOn { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string UMRN { get; set; }
        public string CategoryCode { get; set; }
        public Nullable<bool> IsReverse { get; set; }
    }
}
