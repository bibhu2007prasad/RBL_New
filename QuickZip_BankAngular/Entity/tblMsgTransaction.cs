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
    
    public partial class tblMsgTransaction
    {
        public long msgTransactionId { get; set; }
        public Nullable<long> Mobileno { get; set; }
        public Nullable<long> MandateId { get; set; }
        public Nullable<long> msgCount { get; set; }
        public string msgEvent { get; set; }
        public Nullable<long> msgId { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public Nullable<long> IsActive { get; set; }
        public Nullable<long> IsDeleted { get; set; }
    }
}
