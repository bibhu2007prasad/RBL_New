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
    
    public partial class tblAccessrights_Temp
    {
        public long ID { get; set; }
        public long UserID { get; set; }
        public long LinkID { get; set; }
        public bool IsRead { get; set; }
        public bool IsCreate { get; set; }
        public bool IsEdit { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public long CreatedBy { get; set; }
        public Nullable<long> ModifiedBy { get; set; }
        public string ParallelUserIDs { get; set; }
        public Nullable<bool> IsDownload { get; set; }
        public int RoleID { get; set; }
    }
}
