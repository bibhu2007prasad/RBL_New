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
    
    public partial class tblCustomer
    {
        public long CustomerId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string FatherName { get; set; }
        public string Address { get; set; }
        public string state { get; set; }
        public Nullable<long> pincode { get; set; }
        public Nullable<System.DateTime> dob { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public long CreatedBy { get; set; }
        public long UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
