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
    
    public partial class tblAddressMaster
    {
        public long AddressId { get; set; }
        public Nullable<long> BelongId { get; set; }
        public string BelongTable { get; set; }
        public string AddressType { get; set; }
        public string Pincode { get; set; }
        public string Address { get; set; }
        public Nullable<long> CountryId { get; set; }
        public Nullable<long> StateId { get; set; }
        public Nullable<long> CityId { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public long CreatedBy { get; set; }
        public long UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        public string MaritalStatus { get; set; }
        public string Nationality { get; set; }
        public string GroupName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
    }
}
