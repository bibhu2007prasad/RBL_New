using BusinessLibrary;
using QuickZip_BankAngular.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace QuickZip_BankAngular.Models
{
    public class CorporateSetUpDataAccessLayer
    {
        Demo2_ZipNach_RBLBank_AngularEntities dbcontext = new Demo2_ZipNach_RBLBank_AngularEntities();
        public Dictionary<string, object> BindUtility()
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Entity]").With<UtilityCodeMaster>().Execute("@QueryType", "BindUtilityCode"));
                return Result;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> BindCategoryWithRelated()
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Entity]").With<CategoryCodeMaster>().With<RegionalMaster>().With<PSMMaster>().With<BussinessSegmentMaster>().With<SettlementTypeMaster>().Execute("@QueryType", "BindCategoryCode"));
                return Result;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> BindCountryAndBank()
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Entity]").With<BindCountry>().With<BindBank>().With<EntityBusinessCode>().Execute("@QueryType", "BindCountry"));
                return Result;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Dictionary<string, object> BindGridDataAccess(string UserId, string EntityId)
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Entity]").With<MainGrid>().Execute("@QueryType", "@UserId", "@EntityId", "BindEntity", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%")))));
                return Result;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        //public Dictionary<string, object> SaveDataDataAccess(AllFieldOfForm allFieldOfForm, CorporateSetUp_dtBank dtBankCode, CorporateSetUp_XmlFileName XmlFileName, CorporateSetUp_dtContactPerson dtcontactperson)
            public Dictionary<string, object> SaveDataDataAccess(AllFieldOfForm allFieldOfForm,string EntityId = "")
        {
            try
            {
                #region MyRegion
                EntityId = (EntityId == "0" ? "" : EntityId);
                string dtBankCode = "";
                string Xmldebittype = "";
                string XmlToDebit = "";
                string XmlType = "";
                string Xmlfrequency = "";
                string XmlFileName = "";
                string dtBankAmount = "";
                string dtPaymentMode = "";
                string XmlModeType = "";
                string dtEntityCode = "";
                string EntityBCode = "";
                string UserId = "0";
                string Activate = "";



                string dtBilligMail = "";
                string dtcontactperson = "";
                string XmlFileNameImgDOC = "";

                //Added by Bibhu on 19May2020

                
                string XmlCategoryCode = "";

                XmlCategoryCode = "<dtXml>";
                XmlCategoryCode += "<dtXml ";
                XmlCategoryCode += "categorycode=" + @"""" + allFieldOfForm.categorycodeidNach + @"""";
                XmlCategoryCode += "/>";
                XmlCategoryCode += "</dtXml>";

            if (allFieldOfForm.Activate == true)
                {
                    Activate = "Y";
                }
                else
                {
                    Activate = "N";
                }
                string IsOverPrintMandate = "";
                if (allFieldOfForm.IsOverPrintMandate == true)
                {
                    IsOverPrintMandate = "1";
                }
                else
                {
                    IsOverPrintMandate = "0";
                }
                string IsRefCheck_Ch = "";
                if (allFieldOfForm.IsRefCheck_Ch == true)
                {
                    IsRefCheck_Ch = "1";
                }
                else
                {
                    IsRefCheck_Ch = "0";
                }
                string IsValidationCountEnableCh = "";
                if (allFieldOfForm.IsValidationCountEnableCh)
                {
                    IsValidationCountEnableCh = "1";
                }
                else
                {
                    IsValidationCountEnableCh = "0";
                }
                string IsRefNumerc = "";
                if (allFieldOfForm.IsRefNumerc == true)
                {
                    IsRefNumerc = "1";
                }
                else
                {
                    IsRefNumerc = "0";
                }
                string IsShowMandateMode = "";
                if (allFieldOfForm.IsShowMandateMode == true)
                {
                    IsShowMandateMode = "1";
                }
                else
                {
                    IsShowMandateMode = "0";
                }
                string IsSendEmail = "";
                if (allFieldOfForm.IsSendEmail == true)
                {
                    IsSendEmail = "1";
                }
                else
                {
                    IsSendEmail = "0";
                }
                string IsEMandate = "";
                if (allFieldOfForm.IsEMandate == true)
                {
                    IsEMandate = "1";
                }
                else
                {
                    IsEMandate = "0";
                }
                string IsPhysicalMandateCh = "";
                if (allFieldOfForm.IsPhysicalMandateCh == true)
                {
                    IsPhysicalMandateCh = "1";
                }
                else
                {
                    IsPhysicalMandateCh = "0";
                }
                string chkIsRefrence2Mandatory = "";
                if (allFieldOfForm.chkIsRefrence2Mandatory == true)
                {
                    chkIsRefrence2Mandatory = "1";
                }
                else
                {
                    chkIsRefrence2Mandatory = "0";
                }
                string IsThirdTransactionCh = "";
                if (allFieldOfForm.IsThirdTransactionCh == true)
                {
                    IsThirdTransactionCh = "1";
                }
                else
                {
                    IsThirdTransactionCh = "0";
                }
                string chkIsZipSure_Ch = "";
                if (allFieldOfForm.chkIsZipSure_Ch == true)
                {
                    chkIsZipSure_Ch = "1";
                }
                else
                {
                    chkIsZipSure_Ch = "0";
                }
                string chkIsAllowEManadte_Ch = "";
                if (allFieldOfForm.chkIsAllowEManadte_Ch == true)
                {
                    chkIsAllowEManadte_Ch = "1";
                }
                else
                {
                    chkIsAllowEManadte_Ch = "0";
                }
                string ISTodateMandatoryEnach_Ch = "";
                if (allFieldOfForm.ISTodateMandatoryEnach_Ch == true)
                {
                    ISTodateMandatoryEnach_Ch = "1";
                }
                else
                {
                    ISTodateMandatoryEnach_Ch = "0";
                }
                string recheckthepresentmentfileCh = "";
                if (allFieldOfForm.recheckthepresentmentfileCh == true)
                {
                    recheckthepresentmentfileCh = "1";
                }
                else
                {
                    recheckthepresentmentfileCh = "0";
                }
                string CheckerRequire = "";
                if (allFieldOfForm.CheckerRequire == true)
                {
                    CheckerRequire = "1";
                }
                else
                {
                    CheckerRequire = "0";
                }
                string EnableUserWise_Ch = "";
                if (allFieldOfForm.EnableUserWise_Ch == true)
                {
                    EnableUserWise_Ch = "1";
                }
                else
                {
                    EnableUserWise_Ch = "0";
                }
                string ISEnableCancelUser = "";
                if (allFieldOfForm.ISEnableCancelUser == true)
                {
                    ISEnableCancelUser = "1";
                }
                else
                {
                    ISEnableCancelUser = "0";
                }

                var data = "To"; var NEWDATA = "Untill Cancelled";
                XmlType = "<dtXml>";
                XmlType += "<dtXml ";

                XmlType += "Value=" + @"""" + data + @"""";
                if (allFieldOfForm.To_Ch == true)
                {
                    XmlType += " IsEnable=" + @"""" + 1 + @"""";
                }
                else
                {
                    XmlType += " IsEnable=" + @"""" + 0 + @"""";
                }
                XmlType += " />";

                XmlType += "<dtXml ";
                XmlType += "Value=" + @"""" + NEWDATA + @"""";
                if (allFieldOfForm.UntillCancelled_Ch == true)
                {
                    XmlType += " IsEnable=" + @"""" + 1 + @"""";
                }
                else
                {
                    XmlType += " IsEnable=" + @"""" + 0 + @"""";
                }
                XmlType += " />";
                XmlType += "</dtXml>";
                ////////////////////////////////////
                var SB = "SB"; var CA = "CA"; var CC = "CC"; var SB_NRE = "SB-NRE"; var SB_NRO = "SB-NRO"; var Other = "Other";
                XmlToDebit = "<dtXml>";
                XmlToDebit += "<dtXml ";
                XmlToDebit += "Value=" + @"""" + SB + @"""";
                if (allFieldOfForm.SB_Ch == true)
                {
                    XmlToDebit += " IsEnable=" + @"""" + 1 + @"""";
                }
                else
                {
                    XmlToDebit += " IsEnable=" + @"""" + 0 + @"""";
                }
                XmlToDebit += " />";
                XmlToDebit += "<dtXml ";
                XmlToDebit += "Value=" + @"""" + CA + @"""";
                if (allFieldOfForm.CA_Ch == true)
                {
                    XmlToDebit += " IsEnable=" + @"""" + 1 + @"""";
                }
                else
                {
                    XmlToDebit += " IsEnable=" + @"""" + 0 + @"""";
                }
                XmlToDebit += " />";
                XmlToDebit += "<dtXml ";
                XmlToDebit += "Value=" + @"""" + CC + @"""";
                if (allFieldOfForm.CC_Ch == true)
                {
                    XmlToDebit += " IsEnable=" + @"""" + 1 + @"""";
                }
                else
                {
                    XmlToDebit += " IsEnable=" + @"""" + 0 + @"""";
                }
                XmlToDebit += " />";
                XmlToDebit += "<dtXml ";
                XmlToDebit += "Value=" + @"""" + SB_NRE + @"""";
                if (allFieldOfForm.SB_NRE_Ch == true)
                {
                    XmlToDebit += " IsEnable=" + @"""" + 1 + @"""";
                }
                else
                {
                    XmlToDebit += " IsEnable=" + @"""" + 0 + @"""";
                }
                XmlToDebit += " />";
                XmlToDebit += "<dtXml ";
                XmlToDebit += "Value=" + @"""" + SB_NRO + @"""";
                if (allFieldOfForm.SB_NRO_Ch == true)
                {
                    XmlToDebit += " IsEnable=" + @"""" + 1 + @"""";
                }
                else
                {
                    XmlToDebit += " IsEnable=" + @"""" + 0 + @"""";
                }
                XmlToDebit += " />";
                XmlToDebit += "<dtXml ";
                XmlToDebit += "Value=" + @"""" + Other + @"""";
                if (allFieldOfForm.Other_Ch == true)
                {
                    XmlToDebit += " IsEnable=" + @"""" + 1 + @"""";
                }
                else
                {
                    XmlToDebit += " IsEnable=" + @"""" + 0 + @"""";
                }
                XmlToDebit += " />";
                XmlToDebit += "</dtXml>";
                ////////////////////////////////////////////////////////////////
                var Monthly = "Monthly"; var Quarterly = "Quarterly"; var Half_Yearly = "Half-Yearly"; var Yearly = "Yearly";
                var AsandWhenPresented = "As and When Presented";
                Xmlfrequency = "<dtXml>";
                Xmlfrequency += "<dtXml ";
                Xmlfrequency += "Value=" + @"""" + Monthly + @"""";
                if (allFieldOfForm.Monthly_Ch == true)
                {
                    Xmlfrequency += " IsEnable=" + @"""" + 1 + @"""";
                }
                else
                {
                    Xmlfrequency += " IsEnable=" + @"""" + 0 + @"""";
                }
                Xmlfrequency += " />";
                Xmlfrequency += "<dtXml ";
                Xmlfrequency += "Value=" + @"""" + Quarterly + @"""";
                if (allFieldOfForm.Quarterly_Ch == true)
                {
                    Xmlfrequency += " IsEnable=" + @"""" + 1 + @"""";
                }
                else
                {
                    Xmlfrequency += " IsEnable=" + @"""" + 0 + @"""";
                }
                Xmlfrequency += " />";
                Xmlfrequency += "<dtXml ";
                Xmlfrequency += "Value=" + @"""" + Half_Yearly + @"""";
                if (allFieldOfForm.Half_Yearly_Ch == true)
                {
                    Xmlfrequency += " IsEnable=" + @"""" + 1 + @"""";
                }
                else
                {
                    Xmlfrequency += " IsEnable=" + @"""" + 0 + @"""";
                }
                Xmlfrequency += " />";
                Xmlfrequency += "<dtXml ";
                Xmlfrequency += "Value=" + @"""" + Yearly + @"""";
                if (allFieldOfForm.Yearly_Ch == true)
                {
                    Xmlfrequency += " IsEnable=" + @"""" + 1 + @"""";
                }
                else
                {
                    Xmlfrequency += " IsEnable=" + @"""" + 0 + @"""";
                }
                Xmlfrequency += " />";
                Xmlfrequency += "<dtXml ";
                Xmlfrequency += "Value=" + @"""" + AsandWhenPresented + @"""";
                if (allFieldOfForm.Presented_Ch == true)
                {
                    Xmlfrequency += " IsEnable=" + @"""" + 1 + @"""";
                }
                else
                {
                    Xmlfrequency += " IsEnable=" + @"""" + 0 + @"""";
                }
                Xmlfrequency += " />";
                Xmlfrequency += "</dtXml>";
                /////////////////////////////////////////////////////////////
                var FixedAmount = "Fixed Amount"; var MaximumAmount = "Maximum Amount";
                Xmldebittype = "<dtXml>";
                Xmldebittype += "<dtXml ";
                Xmldebittype += "Value=" + @"""" + FixedAmount + @"""";
                if (allFieldOfForm.FixedAmount_Ch == true)
                {
                    Xmldebittype += " IsEnable=" + @"""" + 1 + @"""";
                }
                else
                {
                    Xmldebittype += " IsEnable=" + @"""" + 0 + @"""";
                }
                Xmldebittype += " />";
                Xmldebittype += "<dtXml ";
                Xmldebittype += "Value=" + @"""" + MaximumAmount + @"""";
                if (allFieldOfForm.MaximumAmount_Ch == true)
                {
                    Xmldebittype += " IsEnable=" + @"""" + 1 + @"""";
                }
                else
                {
                    Xmldebittype += " IsEnable=" + @"""" + 0 + @"""";
                }
                Xmldebittype += " />";
                Xmldebittype += "</dtXml>";
                ////////////////////////////////////////////////////////
                dtPaymentMode = "<dtXml>";
                var Cash = "Cash"; var Cheque = "Cheque"; var DD = "DD"; var E = "E";
                if (allFieldOfForm.Cash_Ch == true)
                {
                    dtPaymentMode += "<dtXml ";
                    dtPaymentMode += "PaymentMode=" + @"""" + Cash + @"""";
                    dtPaymentMode += " />";
                }
                if (allFieldOfForm.Cheque_Ch == true)
                {
                    dtPaymentMode += "<dtXml ";
                    dtPaymentMode += "PaymentMode=" + @"""" + Cheque + @"""";
                    dtPaymentMode += " />";
                }
                if (allFieldOfForm.DemandDraft_Ch == true)
                {
                    dtPaymentMode += "<dtXml ";
                    dtPaymentMode += "PaymentMode=" + @"""" + DD + @"""";
                    dtPaymentMode += " />";
                }
                if (allFieldOfForm.Electronic_Ch == true)
                {
                    dtPaymentMode += "<dtXml ";
                    dtPaymentMode += "PaymentMode=" + @"""" + E + @"""";
                    dtPaymentMode += " />";
                }
                dtPaymentMode += "</dtXml>";
                ///////////////////////////////////////////////////////////////
                XmlModeType = "<dtXml>";
                XmlModeType += "<dtXml ";
                if (allFieldOfForm.IsPhysicalMandateCh == true)
                {
                    XmlModeType += " Physical=" + @"""" + 1 + @"""";

                    if (allFieldOfForm.ValidationByCustomer_Ch == true)
                    {
                        XmlModeType += " customer=" + @"""" + 1 + @"""";
                    }
                    else
                    {
                        XmlModeType += " customer=" + @"""" + 0 + @"""";
                    }
                    if (allFieldOfForm.ValidationByCorporate_Ch == true)
                    {
                        XmlModeType += " cooperate=" + @"""" + 1 + @"""";
                    }
                    else
                    {
                        XmlModeType += " cooperate=" + @"""" + 0 + @"""";
                    }
                    if (allFieldOfForm.OCRCode_Ch == true)
                    {
                        XmlModeType += " ocr=" + @"""" + 1 + @"""";
                    }
                    else
                    {
                        XmlModeType += " ocr=" + @"""" + 0 + @"""";
                    }
                }
                else
                {
                    XmlModeType += " Physical=" + @"""" + 0 + @"""";
                    XmlModeType += " customer=" + @"""" + 0 + @"""";
                    XmlModeType += " cooperate=" + @"""" + 0 + @"""";
                    XmlModeType += " ocr=" + @"""" + 0 + @"""";
                }
                if (allFieldOfForm.QRCode_Ch == true)
                {
                    XmlModeType += " Qr=" + @"""" + 1 + @"""";
                }
                else
                {
                    XmlModeType += " Qr=" + @"""" + 0 + @"""";
                }
                if (allFieldOfForm.Logo_Ch == true)
                {
                    XmlModeType += " logo=" + @"""" + 1 + @"""";
                }
                else
                {
                    XmlModeType += " logo=" + @"""" + 0 + @"""";
                }
                XmlModeType += " />";
                XmlModeType += "</dtXml>";
                #endregion
                dtBankCode = allFieldOfForm.dtBankCode.ToString();
                //XmlModeType=< dtXml >< dtXml  physical = "1" customer = "0" cooperate = "1" ocr = "0" Qr = "0" logo = "1" Customerphnumber = "1" Customeremailid = "1" emandate = "1" netbanking = "1" debit = "0" aadhar = "0" mail = "1" netmanual = "0" sms = "0" debitmail = "0" debitmanual = "0" debitsms = "0" aadharmail = "0" aadharmanual = "0" aadharsms = "0" accountvalidation = "1" Presentment = "1" /></ dtXml >
                dtBankAmount = "<dtXml></dtXml>"; ;
                // dtBankAmount = dtBankCode;
                // dtBankCode = "<dtXml></dtXml>";//<dtXml><dtXml SponsorBankName ="RBL Bank" SponsorBankcode ="ICIC0000037" IFSC ="ICIC0000037" UtilityCode ="UTIB0000001" AccountNumber ="003701550558"  /></dtXml>
                dtBankCode = "<dtXml><dtXml SponsorBankName =" + @"""" + allFieldOfForm.dtBankCode[0] + @""""  + " SponsorBankcode =" + @"""" + allFieldOfForm.dtBankCode[1] + @"""" + " IFSC =" + @"""" + allFieldOfForm.dtBankCode[3] + @"""" + " UtilityCode =" + @"""" + allFieldOfForm.dtBankCode[2] + @"""" + " AccountNumber =" + @"""" + allFieldOfForm.dtBankCode[4] + @"""" + "  /></dtXml>";
                //XmlFileName = "<dtXml></dtXml>";//<dtXml><dtXml SponsorBankCode="ICIC0000037" FileName1="fILENAME1" FileName2="fILENAME2" FileName3="fILENAME3" FileName4="fILENAME4" FileName5="fILENAME5" FileName6="fILENAME6"  /></dtXml>
                XmlFileName = "<dtXml><dtXml SponsorBankCode=" + @"""" + allFieldOfForm.XmlFileName[0] + @"""" + " FileName1=" + @"""" + allFieldOfForm.XmlFileName[1] + @"""" + " FileName2=" + @"""" + allFieldOfForm.XmlFileName[2] + @"""" + " FileName3=" + @"""" + allFieldOfForm.XmlFileName[3] + @"""" + " FileName4=" + @"""" + allFieldOfForm.XmlFileName[4] + @"""" + " FileName5=" + @"""" + allFieldOfForm.XmlFileName[5] + @"""" + " FileName6=" + @"""" + allFieldOfForm.XmlFileName[6] + @"""" + "  /></dtXml>";

                dtEntityCode = "<dtXml></dtXml>";

                dtBilligMail = "<dtXml></dtXml>"; ;
                // dtcontactperson = "<dtXml></dtXml>"; //;< dtXml >< dtXml ContactPersonName = "CONTACTPERNAME" Designation = "CONTACT  DESIG" ContactNo = "9876543211" FaxNo = "11111111111" Address = "CONTACT PERS ADDRESS" /></ dtXml >
                dtcontactperson = "<dtXml><dtXml ContactPersonName = " + @"""" + allFieldOfForm.dtcontactperson[0] + @"""" + " Designation = " + @"""" + allFieldOfForm.dtcontactperson[1] + @"""" + " ContactNo = " + @"""" + allFieldOfForm.dtcontactperson[2] + @"""" + " FaxNo = " + @"""" + allFieldOfForm.dtcontactperson[3] + @"""" + " Address = " + @"""" + allFieldOfForm.dtcontactperson[4] + @"""" + " /></dtXml>";
                XmlFileNameImgDOC = "<dtXml></dtXml>"; ; //"<dtXml><dtXml ImgPath="../ images / getData.png" DocName="Upload Adhar Card" Doc_TypeId1="1"  /><dtXml ImgPath="../ images / getData.png" DocName="Upload Pan Card" Doc_TypeId1="2"  /><dtXml ImgPath="../ images / getData.png" DocName="Upload test doc" Doc_TypeId1="3"  /><dtXml ImgPath="../ images / getData.png" DocName="Upload TEST 6" Doc_TypeId1="4"  /><dtXml ImgPath="../ images / getData.png" DocName="Upload 007 desc up" Doc_TypeId1="5"  /></dtXml>";
                string AppID = Convert.ToString(ConfigurationManager.AppSettings["APPId"]);
                string CorporateId = "1";//Added by Bibhu 19May2020 for temp
                // EntityBCode = "<dtXml></dtXml>";
                EntityBCode = allFieldOfForm.categorycodeid; //Added by Bibhu on 19may2020
                string netbanking = "";
                string mail = "";
                string netmanual = "";
                string sms = "";
                string debit = "";
                string debitmail = "";
                string debitmanual = "";
                string debitsms = "";
                string aadhar = "";
                string aadharmail = "";
                string aadharmanual = "";
                string aadharsms = "";
                string accountvalidation = "";
                string Customerphnumber = "";
                string Customeremailid = "";
             //   string XmlModeType = "";
                string IsNachPresentment = "";
                string XmlFinancialDetails = "";

                string dfltpswd = "1";
                string PAN = "";
                string TAN = "";
                string GSTIN = "";
                string billingaddress = allFieldOfForm.BillingAddress;
                string debitaccno = allFieldOfForm.BillingChargeDebitAccNo;
                string bankcorpid = allFieldOfForm.BillingBankCorpId;
                string branchname = allFieldOfForm.BillingBranchName;
                string branchcode = allFieldOfForm.BillingBranchCode;
                string ifsc = allFieldOfForm.BillingIFSC;
                string billingcontactperson = allFieldOfForm.BillContractPerson;
                string designation = allFieldOfForm.Designation;
                string contactno = allFieldOfForm.BillingContactNo;
                string faxno = allFieldOfForm.BillFaxNo;
                string Arrangementdays = allFieldOfForm.Arrangementdays;
                string pickupaddress = allFieldOfForm.BillingPicupLocationAddress;
                string pickupcontactperson = allFieldOfForm.BillingPicupContactPerson;
                string mailprimary = allFieldOfForm.BillingCommunicationMailPrimary;
                string psm = allFieldOfForm.PSMId;
                string regionalmgr = allFieldOfForm.RMId;
                string ip = allFieldOfForm.BillingIP;
                string url = allFieldOfForm.BillingURL;
                string h2husername = allFieldOfForm.BillingUserName;
                string h2hpassword = allFieldOfForm.BillingPassword;
                string Referencelength = allFieldOfForm.IstxtMaxlenth;
                string ReferenceRdoValue ="";
                if(allFieldOfForm.IsrdoFixed==true)
                {
                    ReferenceRdoValue = "F";
                }
                if (allFieldOfForm.IsrdoMaxLength == true)
                {
                    ReferenceRdoValue = "M";
                }
                //if (allFieldOfForm.NachPresentment == true)
                //{
                //    IsNachPresentment = "1";
                //}
                //else
                //{
                //    IsNachPresentment = "0";
                //}
                //if (jquery_1_11_3_min_p("input:radio[name=ReferenceRdo]:checked").val() == "1")
                //{
                //    ReferenceRdoValue = 'F';
                //}
                //else
                //{
                //    ReferenceRdoValue = 'M';
                //}



                //if (jquery_1_11_3_min_p('#chkPresentment').prop("checked") == true)
                //{
                //    IsNachPresentment = 1;
                //}
                //else
                //{
                //    IsNachPresentment = 0;
                //}

               
                //added by garima on 21-02-2020
                string settlementtype = allFieldOfForm.SettlementTypeId;
                string businesssegment = allFieldOfForm.BusinessSegmentId;




                if (allFieldOfForm.NachPresentment == true)
                {
                    IsNachPresentment = "1";
                }
                else
                {
                    IsNachPresentment = "0";
                }
                DataTable dt = null;
                string password = string.Empty;
                string passwordKey = string.Empty;
                string confirmpassword = string.Empty;
                //if (allFieldOfForm.confirmpassword.Trim() != "")
                //{

                    //password = DbSecurity.Encrypt(confirmpassword, ref passwordKey);
                    //confirmpassword = Convert.ToString(ConfigurationManager.AppSettings["DefaultPswdEntity"]);
                    confirmpassword = Convert.ToString(allFieldOfForm.Code).ToUpper() + "@123";
                    password = DbSecurity.Encrypt(confirmpassword, ref passwordKey);
                //}
                if (UserId == "undefined")
                {
                    UserId = "0";
                }

                if (EntityId.Trim() == "")

                {

                    var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Entity]").With<CommonClass>().Execute(
"@QueryType", "@InstructingMemberId", "@XmlSponsorBankCode", "@Type", "@Code", "@Name", "@ContactPerson",
 "@SponsorBankCode", "@UtilityCode", "@SponsorBankName", "@UserId", "@Addr1", "@Email", "@CountryId", "@CityId", "@StateId",
 "@Mobile", "@Pincode", "@ImagePath", "@UserName", "@password", "@passwordKey", "@DebitType", "@FrequencyType", "@ToDebit", "@Amount", "@Activate", "@XmlPaymentMode", "@EntityBusinessCode", "@IsOverMandate", "@IsRefrenceCheck",
 "@IsValidationCountEnable","@BankValidationAdminCount", "@BankValidationUserCount", "@AcValidationAdminCount", "@AcValidationUserCount", "@IsRefNumerc",
"@IsShowMandateMode", "@IsSendEmailCustomer", "@IschkEmandate", "@IschkPhysical", "@Xmldebittype", "@XmlToDebit", "@XmlType", "@Xmlfrequency", "@chkIsRefrence2Mandatory", "@dtBankAmount", "@IsThirdTransaction", "@chkIsZipSure"
 , "@chkIsAllowEManadte", "@ISTodateMandatoryEnach","@APPId", "@XmlFileName", "@AccountNumber", "@ReCheck", "@CheckerRequire", "@XmlModeType", "@XmlCategoryCode", "@PAN", "@TAN", "@GSTIN", "@IsNachPresentment"
 , "@BillingAddress", "@ChargeDebitAcNo", "@BankCorporateId", "@BranchName", "@BranchCode", "@IFSC", "@RegionalManagerId",
"@PSM", "@BillingContactPerson", "@Designation", "@ContactNo", "@FaxNo", "@ArrangementInDays", "@PickUpLocationAddress",
"@PickUpContactPerson", "@CommunicationMailPrimary", "@Ip", "@Url", "@h2husername", "@h2hpassword", "@dtBilligMail", "@CorporateId", "@Referencelength",
"@ReferenceRdoValue", "@SettlementTypeId", "@BusinessSegmentId", "@dtcontactperson", "@XmlFileNameImgDOC",
        "SaveData",allFieldOfForm.InstructingMenmerId, dtBankCode.ToString(), allFieldOfForm.Type, allFieldOfForm.Code, allFieldOfForm.EntityName,
allFieldOfForm.Name, allFieldOfForm.BankCode, allFieldOfForm.UtilityCode, allFieldOfForm.BankName, UserId, allFieldOfForm.Address, allFieldOfForm.Email, allFieldOfForm.Country, allFieldOfForm.City
,allFieldOfForm.State, allFieldOfForm.MobileNo, allFieldOfForm.PinCode, allFieldOfForm.FullPath, allFieldOfForm.UserName, password, passwordKey,
allFieldOfForm.DebitType, allFieldOfForm.FrequencyType, allFieldOfForm.ToDebit, allFieldOfForm.Amount, Activate, dtPaymentMode, EntityBCode, IsOverPrintMandate, IsRefCheck_Ch, IsValidationCountEnableCh
,allFieldOfForm.BankValidationAdminCount, allFieldOfForm.BankValidationUserCount, allFieldOfForm.AcValidationAdminCount, allFieldOfForm.AcValidationUserCount, IsRefNumerc, IsShowMandateMode, IsSendEmail, IsEMandate,
IsPhysicalMandateCh, Xmldebittype, XmlToDebit, XmlType, Xmlfrequency, chkIsRefrence2Mandatory, dtBankAmount, IsThirdTransactionCh, chkIsZipSure_Ch,chkIsAllowEManadte_Ch, ISTodateMandatoryEnach_Ch,
AppID, XmlFileName.ToString(), allFieldOfForm.AccountNumber, recheckthepresentmentfileCh, CheckerRequire, XmlModeType, XmlCategoryCode,allFieldOfForm.PAN, allFieldOfForm.TAN, allFieldOfForm.GST, IsNachPresentment
, billingaddress, debitaccno,bankcorpid,branchname,branchcode,ifsc,regionalmgr,psm, billingcontactperson,designation,contactno,faxno,Arrangementdays,pickupaddress,pickupcontactperson, mailprimary
,ip,url,h2husername,h2hpassword, dtBilligMail,CorporateId, Referencelength, ReferenceRdoValue, settlementtype, businesssegment, dtcontactperson.ToString(), XmlFileNameImgDOC));
                    return Result;
                }
                else  {
                    var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Entity]").With<CommonClass>().Execute(
"@QueryType", "@InstructingMemberId", "@XmlSponsorBankCode", "@Type", "@EntityId", "@Code", "@Name", "@ContactPerson",
"@SponsorBankCode", "@UtilityCode", "@SponsorBankName", "@UserId", "@Addr1", "@Email", "@CountryId", "@CityId", "@StateId",
"@Mobile", "@Pincode", "@ImagePath", "@UserName", "@password", "@passwordKey"
, "@DebitType", "@FrequencyType", "@ToDebit", "@Amount", "@Activate", "@XmlPaymentMode", "@EntityBusinessCode", "@IsOverMandate",
"@IsRefrenceCheck", "@IsValidationCountEnable"
, "@BankValidationAdminCount", "@BankValidationUserCount", "@AcValidationAdminCount", "@AcValidationUserCount", "@IsRefNumerc",
"@IsShowMandateMode", "@IsSendEmailCustomer", "@IschkEmandate", "@IschkPhysical", "@Xmldebittype", "@XmlToDebit", "@XmlType", "@Xmlfrequency", "@chkIsRefrence2Mandatory", "@dtBankAmount", "@IsThirdTransaction", "@chkIsZipSure", "@chkIsAllowEManadte", "@ISTodateMandatoryEnach", "@XmlFileName", "@ReCheck", "@CheckerRequire", "@XmlModeType", "@XmlCategoryCode", "@PAN", "@TAN", "@GSTIN", "@IsNachPresentment", "@BillingAddress", "@ChargeDebitAcNo", "@BankCorporateId", "@BranchName", "@BranchCode", "@IFSC", "@RegionalManagerId",
"@PSM", "@BillingContactPerson", "@Designation", "@ContactNo", "@FaxNo", "@ArrangementInDays", "@PickUpLocationAddress", "@PickUpContactPerson", "@CommunicationMailPrimary", "@Ip", "@Url",
"@h2husername", "@h2hpassword", "@dtBilligMail", "@CorporateId", "@Referencelength", "@ReferenceRdoValue", "@SettlementTypeId", "@BusinessSegmentId", "@dtcontactperson", "@XmlFileNameImgDOC",
"UpdateData", allFieldOfForm.InstructingMenmerId, dtBankCode.ToString(), allFieldOfForm.Type,EntityId, allFieldOfForm.Code, allFieldOfForm.EntityName,
allFieldOfForm.Name, allFieldOfForm.BankCode, allFieldOfForm.UtilityCode, allFieldOfForm.BankName, UserId, allFieldOfForm.Address, allFieldOfForm.Email, allFieldOfForm.Country, allFieldOfForm.City
, allFieldOfForm.State, allFieldOfForm.MobileNo, allFieldOfForm.PinCode, allFieldOfForm.FullPath, allFieldOfForm.UserName, password, passwordKey,
allFieldOfForm.DebitType, allFieldOfForm.FrequencyType, allFieldOfForm.ToDebit, allFieldOfForm.Amount, Activate, dtPaymentMode, EntityBCode, IsOverPrintMandate, IsRefCheck_Ch, IsValidationCountEnableCh
, allFieldOfForm.BankValidationAdminCount, allFieldOfForm.BankValidationUserCount, allFieldOfForm.AcValidationAdminCount, allFieldOfForm.AcValidationUserCount, IsRefNumerc, IsShowMandateMode, IsSendEmail, IsEMandate,
IsPhysicalMandateCh, Xmldebittype, XmlToDebit, XmlType, Xmlfrequency, chkIsRefrence2Mandatory, dtBankAmount, IsThirdTransactionCh, chkIsZipSure_Ch, chkIsAllowEManadte_Ch, ISTodateMandatoryEnach_Ch,
AppID, XmlFileName.ToString(), allFieldOfForm.AccountNumber, recheckthepresentmentfileCh, CheckerRequire, XmlModeType, XmlCategoryCode, allFieldOfForm.PAN, allFieldOfForm.TAN, allFieldOfForm.GST, IsNachPresentment
, billingaddress, debitaccno, bankcorpid, branchname, branchcode, ifsc, regionalmgr, psm, billingcontactperson, designation, contactno, faxno, Arrangementdays, pickupaddress, pickupcontactperson, mailprimary
, ip, url, h2husername, h2hpassword, dtBilligMail, CorporateId, Referencelength, ReferenceRdoValue, settlementtype, businesssegment, dtcontactperson.ToString(), XmlFileNameImgDOC));
                    return Result;
                }
                
            }
            
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Dictionary<string, object> EditEntity(string EntityId)
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Entity]").With<Table>().With<Table1>().With<Table2>().With<Table3>().With<Table4>().With<Table5>().With<Table6>().With<Table7>().With<Table8>().With<Table9>().With<Table10>()
                .With<Table11>().With<Table12>().With<Table13>().With<Table14>().With<Table15>().With<Table16>().With<Table17>().With<Table18>().With<Table19>().With<Table20>().Execute("@QueryType", "@EntityId", "EditEntity", EntityId));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Dictionary<string, object> BindStateDataAccess(string CountryId)
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Entity]").With<BindState>().Execute("@QueryType", "@CountryId", "Bindstate", CountryId));
                return Result;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Dictionary<string, object> BindCityDataAccess(string StateId)
        {
            try
            {
                var Result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Entity]").With<BindCity>().Execute("@QueryType", "@StateId", "BindCity", StateId));
                return Result;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}