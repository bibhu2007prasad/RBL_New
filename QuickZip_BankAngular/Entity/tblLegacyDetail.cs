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
    
    public partial class tblLegacyDetail
    {
        public Nullable<long> UploadHeaderId { get; set; }
        public string UMRN { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string Refrence { get; set; }
        public string Status { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<long> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdateOn { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string CustomerName { get; set; }
        public string Type { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public long DetailId { get; set; }
        public Nullable<long> EntityId { get; set; }
        public string AccountType { get; set; }
        public string AccountNo { get; set; }
        public string IFSC { get; set; }
        public string AmountType { get; set; }
    }
}
