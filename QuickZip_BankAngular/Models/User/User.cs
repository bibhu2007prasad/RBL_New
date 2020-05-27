using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZip_BankAngular.Models
{
    public class User
    {
        public string IsDeleted { get; set; }
        public Int32 Srno { get; set; }
        public Int64 UserId { get; set; }
        public string UserName { get; set; }

        public string EmailId { get; set; }
        public string PhoneNo { get; set; }
        public string Type { get; set; }
        public string DesignationName { get; set; }
        public string Corp_Name { get; set; }
        public string Bank_Name { get; set; }
    }
}