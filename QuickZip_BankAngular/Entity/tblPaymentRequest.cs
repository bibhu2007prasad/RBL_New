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
    
    public partial class tblPaymentRequest
    {
        public long PaymentReqId { get; set; }
        public Nullable<long> MandateId { get; set; }
        public Nullable<long> EntityId { get; set; }
        public string MessageCode { get; set; }
        public Nullable<long> RequestDateTime { get; set; }
        public string MerchantId { get; set; }
        public string TraceNo { get; set; }
        public string RequestType { get; set; }
        public string BeniIFSC { get; set; }
        public string BeniACNo { get; set; }
        public string BeniAmount { get; set; }
        public string Remarks { get; set; }
        public string BeniAcType { get; set; }
        public string Filler1 { get; set; }
        public string Filler2 { get; set; }
        public string Filler3 { get; set; }
        public string Filler4 { get; set; }
        public string Filler5 { get; set; }
        public string ChkSum { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public long CreatedBy { get; set; }
        public long UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public string msg { get; set; }
        public Nullable<long> ActivityId { get; set; }
    }
}
