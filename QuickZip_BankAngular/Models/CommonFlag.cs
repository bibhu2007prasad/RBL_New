using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;

namespace QuickZip_BankAngular.Models
{
    public class CommonFlag
    {
        public string Flag { get; set; }
        public string FlagValue { get; set; }
        public string IsZipShoreABPS { get; set; }
        public string IsRefrenceCheck { get; set; }
        public string IsOverPrintMandate { get; set; }
        public string IsMandateEdit { get; set; }
        public string IsRefrenceEdit { get; set; }
        public string IsBulkMandate { get; set; }
        public string IsMandate { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string BranchName { get; set; }
        public string EmailId { get; set; }
        public string PhoneNo { get; set; }
        public string UserType { get; set; }
        public Nullable<Int64> ReferenceId { get; set; }
        public string Password { get; set; }
        public string PasswordKey { get; set; }
        public string UserCode { get; set; }
        public string  IsActive { get; set; }
        public string IsDeleted { get; set; }
        public string IsLoginFirstTime { get; set; }
        public string LastLogin { get; set; }
        public Nullable<Int64> UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public Nullable<Int64> CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public Nullable<int> BranchId { get; set; }
        public string IsDefaultPswdChange { get; set; }
        public string IsPhysical { get; set; }
        public string IsEmandate { get; set; }
    }
    

}