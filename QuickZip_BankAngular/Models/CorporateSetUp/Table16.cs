using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZip_BankAngular.Models
{
    public class Table16
    {
        public Int64 EntityId { get; set; }
        public Int64 BankMasterId { get; set; }
        public string PAN_No { get; set; }
        public string TAN_No { get; set; }
        public string GSTIN_No { get; set; }
        public string BillingAddress { get; set; }
        public string ChargeDebitAcNo { get; set; }
        public string BankCorporateId { get; set; }
        public string BranchName { get; set; }
        public string BranchCode { get; set; }
        public string IFSC { get; set; }
        public string RM_Name { get; set; }
        public string PSM_Name { get; set; }
        public string BillingContactPerson { get; set; }
        public string Designation { get; set; }
        public string ContactNo { get; set; }
        public string FaxNo { get; set; }
        public Int32 ArrangementInDays { get; set; }
        public string PickUpLocationAddress { get; set; }
        public string PickUpContactPerson { get; set; }
        public string CommunicationMailPrimary { get; set; }
        public string BusinessSegmentName { get; set; }
        public string SettlementType { get; set; }
    }
}