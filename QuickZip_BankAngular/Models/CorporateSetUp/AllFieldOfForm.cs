using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuickZip_BankAngular.Models
{
    public class AllFieldOfForm
    {
        public Boolean AadhaarCardCh { get; set; }
        public Boolean ActivePaymentModeCh { get; set; }
        public string Address { get; set; }
        public string AppID { get; set; }
        public Boolean CA_Ch { get; set; }
        public Boolean CC_Ch { get; set; }
        public Boolean Cash_Ch { get; set; }
        public Boolean Cheque_Ch { get; set; }
        public string City { get; set; }
        public string Code { get; set; }
        public string Country { get; set; }
        public Boolean DebitCardCh { get; set; }
        public Boolean DemandDraft_Ch { get; set; }
        public Boolean Electronic_Ch { get; set; }
        public string Email { get; set; }
        public string EntityBCode { get; set; }
        public string EntityName { get; set; }
        public Boolean ISTodateMandatoryEnach_Ch { get; set; }
        public Boolean IsEMandate { get; set; }
        public Boolean IsOverPrintMandate { get; set; }
        public Boolean IsPhysicalMandateCh { get; set; }
        public Boolean IsRefCheck_Ch { get; set; }
        public Boolean IsRefNumerc { get; set; }
        public Boolean IsSendEmail { get; set; }
        public Boolean IsShowMandateMode { get; set; }
        public Boolean IsThirdTransactionCh { get; set; }
        public string MerchantKey { get; set; }
        public string MobileNo { get; set; }
        public string Name { get; set; }
        public Boolean NetBankingCh { get; set; }
        public Boolean Other_Ch { get; set; }
        public string PinCode { get; set; }
        public Boolean SB_Ch { get; set; }
        public Boolean SB_NRE_Ch { get; set; }
        public Boolean SB_NRO_Ch { get; set; }
        public string State { get; set; }
        public string UserName { get; set; }
        public Boolean chkIsAllowEManadte_Ch { get; set; }
        public Boolean chkIsRefrence2Mandatory { get; set; }
        public Boolean chkIsZipSure_Ch { get; set; }
        public Boolean recheckthepresentmentfileCh { get; set; }

        public string BankName { get; set; }
        public string BankCode { get; set; }
        public string UtilityCode { get; set; }
        public string Password { get; set; }
        public string confirmpassword { get; set; }
        public string AccountNumber { get; set; }
       // public Boolean ReCheck { get; set; }
        public Boolean CheckerRequire { get; set; }
        public string XmlModeType { get; set; }
        //public Boolean IsEnableUserCheck { get; set; }
        public Boolean ISEnableCancelUser { get; set; }
//public string dtEntityCode { get; set; }
        public string FullPath { get; set; }
        public string BankValidationAdminCount { get; set; }
        public string BankValidationUserCount { get; set; }
        public string AcValidationAdminCount { get; set; }
        public string AcValidationUserCount { get; set; }
        public Boolean EnableUserWise_Ch { get; set; }
        public Boolean IsValidationCountEnableCh { get; set; }
        public string InstructingMenmerId { get; set; }
        public string Type { get; set; }
        public string DebitType { get; set; }
        public string FrequencyType { get; set; }
        public string ToDebit { get; set; }
        public string Amount { get; set; }
        public Boolean Activate { get; set; }
        public string FileName1 { get; set; }
        public string FileName2 { get; set; }
        public string FileName3 { get; set; }
        public string FileName4 { get; set; }
        public string FileName5 { get; set; }
        public string FileName6 { get; set; }
        public Boolean FixedAmount_Ch { get; set; }
        public Boolean MaximumAmount_Ch { get; set; }
        public Boolean Half_Yearly_Ch { get; set; }
        public Boolean UntillCancelled_Ch { get; set; }
        public Boolean To_Ch { get; set; }
        public Boolean Monthly_Ch { get; set; }
        public Boolean Quarterly_Ch { get; set; }
        public Boolean Yearly_Ch { get; set; }
        public Boolean Presented_Ch { get; set; }
        public Boolean ValidationByCustomer_Ch { get; set; }
        public Boolean ValidationByCorporate_Ch { get; set; }
        public Boolean OCRCode_Ch { get; set; }
        public Boolean QRCode_Ch { get; set; }
        public Boolean Logo_Ch { get; set; }


        //Added by Bibhu on 18May2020 start
        public string EmailId { get; set; }
        public string IsAccountValidation { get; set; }
        public string IsPhoneNumber { get; set; }
        //public string IsReferenceNumeric { get; set; }
        public Boolean IsrdoFixed { get; set; }
        public Boolean IsrdoMaxLength { get; set; }
        public string IstxtMaxlenth { get; set; }

        //Added by Bibhu on 18May2020 start //Financial and Billing 
        public string FinaceAndBillingName { get; set; }
        public string FinaceAndBillingDesignation { get; set; }
        public string FinaceAndBillingContactNo { get; set; }
        public string FinaceAndBillingFaxNo { get; set; }
        public string FinaceAndBillingAddress { get; set; }
        public string PAN { get; set; }
        public string TAN { get; set; }


        public string GST { get; set; }
        public string BillContractPerson { get; set; }
        public string Designation { get; set; }
        public string BillingContactNo { get; set; }
        public string BillFaxNo { get; set; }
        public string BillingAddress { get; set; }
        public string BillingPicupContactPerson { get; set; }


        public string BillingPicupLocationAddress { get; set; }
        public string BillingCommunicationMailPrimary { get; set; }
        public string BillingCommunicationMailBilling { get; set; }
        public string BillingChargeDebitAccNo { get; set; }
        public string BillingBankCorpId { get; set; }
        public string BillingBranchName { get; set; }
        public string BillingBranchCode { get; set; }

        public string BillingIFSC { get; set; }
        public string IsRequired { get; set; }

        //Added by Bibhu on 18May2020 start //Financial and Billing 
        public string categorycodeid { get; set; }
        public string UtilityCodeId { get; set; }
        public string categorycodeidNach { get; set; }
        public string BusinessSegmentId { get; set; }
        public string RMId { get; set; }
        public string PSMId { get; set; }
        public string Arrangementdays { get; set; }
        public string SettlementTypeId { get; set; }


        //Added by Bibhu on 19may2020
        public Boolean NachPresentment { get; set; }
        public string BillingIP { get; set; }
        public string BillingURL { get; set; }
        public string BillingUserName { get; set; }
        public string BillingPassword { get; set; }

        public string[] dtBankCode { get; set; }
        public string[] XmlFileName { get; set; }
        public string[] dtcontactperson { get; set; }
    }
}