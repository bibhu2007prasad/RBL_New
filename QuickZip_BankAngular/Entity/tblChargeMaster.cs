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
    
    public partial class tblChargeMaster
    {
        public long CMId { get; set; }
        public string UtilityCode { get; set; }
        public Nullable<long> EnityId { get; set; }
        public Nullable<long> BankId { get; set; }
        public Nullable<int> TxnType { get; set; }
        public Nullable<decimal> MandatePrintingCharges { get; set; }
        public Nullable<decimal> MandateCharge { get; set; }
        public Nullable<decimal> TxnCharge { get; set; }
        public Nullable<decimal> MandateReturnCharges { get; set; }
        public Nullable<decimal> TransactionReturncharges { get; set; }
        public Nullable<decimal> CourierCharges { get; set; }
        public Nullable<decimal> DispatchCharges { get; set; }
        public Nullable<decimal> ChargeAdvice { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<long> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    }
}
