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
    
    public partial class tblMandateStatu
    {
        public long Status_id { get; set; }
        public long MandateId { get; set; }
        public Nullable<long> MandateStatusId { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<long> ActivityId { get; set; }
        public string MandateStatus { get; set; }
        public string Mandaterejectreason { get; set; }
        public string Mandateresponsedescription { get; set; }
    }
}
