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
    
    public partial class TblRolePolicy
    {
        public long RolePolicyID { get; set; }
        public int RoleID { get; set; }
        public int LinkID { get; set; }
        public bool IsRead { get; set; }
        public bool IsWrite { get; set; }
        public bool IsDownLoad { get; set; }
        public int EntityID { get; set; }
        public int MasterBankID { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public int CreatedBy { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
    }
}
