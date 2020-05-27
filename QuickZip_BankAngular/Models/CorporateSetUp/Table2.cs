using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZip_BankAngular.Models
{
    public class Table2
    {
        public Int64 CountryId { get; set; }
        public Int64 CityId { get; set; }
        public Int64 StateId { get; set; }
        
        public string Address { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Pincode { get; set; }
       
    }
}