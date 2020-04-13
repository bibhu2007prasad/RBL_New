using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessLibrary;
using QuickZip_BankAngular.Entity;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
namespace QuickZip_BankAngular.Models.Login
{
    public class Login
    {
        Demo2_ZipNach_RBLBank_AngularEntities dbcontext = new Demo2_ZipNach_RBLBank_AngularEntities();
        List<CommonFlag> common = new List<CommonFlag>();
        CommonFlag Flag = new CommonFlag();
        public IEnumerable<CommonFlag> Binddetails(string Username, string Password)
        {
            List<Logindetails> dataList = new List<Logindetails>();
            try
            {
                var Result = dbcontext.MultipleResults("[dbo].[sp_UserLogin]").With<Logindetails>().Execute("@QueryType", "@UserName", "GetUser", Username);
                foreach (var Logindata in Result)
                {
                    dataList = Logindata.Cast<Logindetails>().ToList();
                    if (dataList.Count > 0)
                    {
                        string strDbPassword = DbSecurity.Decrypt(Convert.ToString(Logindata.Cast<Logindetails>().ToList().Select(x => x.Password).First().ToString()), Convert.ToString(Logindata.Cast<Logindetails>().ToList().Select(x => x.PasswordKey).First().ToString()));
                        if (strDbPassword.Trim() != Password)
                        {
                            Flag.Flag = "0";
                            Flag.FlagValue = "Wrong Username or Password!!";
                            common.Add(Flag);
                        }
                        else
                        {
                            Random generator = new Random();
                            Demo2_ZipNach_RBLBank_AngularEntities dbcontext = new Demo2_ZipNach_RBLBank_AngularEntities();
                            var SaveLoginSessionTrxn = dbcontext.MultipleResults("[dbo].[sp_UserLogin]").With<SaveLoginSessionTrxn>().Execute("@QueryType", "@UserId", "@TokenID", "@IPAddress", "@MacAddress", "@IsLogin", "SaveLoginSessionTrxn", Convert.ToString(Logindata.Cast<Logindetails>().ToList().Select(x => x.UserId).First().ToString()), Convert.ToString(generator.Next(1, 1000000)), Convert.ToString(GetIpAddress()), Convert.ToString(GetMacAddress()), Convert.ToString(1));
                            foreach (var Existlogin in SaveLoginSessionTrxn)
                            {
                                if (Existlogin.Cast<SaveLoginSessionTrxn>().ToList().Select(x => x.SessionActive).First().ToString() == "1")
                                {

                                    #region Session creation
                                    // Iace.User.User.SaveUserToSession(dataList);
                                    Flag.IsRefrenceCheck = Convert.ToString(dataList.Cast<Logindetails>().ToList().Select(x => x.IsRefrenceCheck).First().ToString());
                                    Flag.IsOverPrintMandate = Convert.ToString(dataList.Cast<Logindetails>().ToList().Select(x => x.IsOverPrintMandate).First().ToString());
                                    Flag.IsBulkMandate = Convert.ToString(dataList.Cast<Logindetails>().ToList().Select(x => x.IsBulkMandate).First().ToString());
                                    Flag.IsMandate = Convert.ToString(dataList.Cast<Logindetails>().ToList().Select(x => x.IsMandate).First().ToString());
                                    //NewCode
                                    Flag.IsMandateEdit = Convert.ToString(dataList.Cast<Logindetails>().ToList().Select(x => x.IsMandateEdit).First().ToString());
                                    Flag.IsRefrenceEdit = Convert.ToString(dataList.Cast<Logindetails>().ToList().Select(x => x.IsRefrenceEdit).First().ToString());
                                    Flag.IsEmandate = Convert.ToString(dataList.Cast<Logindetails>().ToList().Select(x => x.IsEmandate).First().ToString());
                                    Flag.IsPhysical = Convert.ToString(dataList.Cast<Logindetails>().ToList().Select(x => x.IsPhysical).First().ToString());
                                    Flag.IsZipShoreABPS = Convert.ToString(dataList.Cast<Logindetails>().ToList().Select(x => x.IsZipShoreABPS).First().ToString());
                                    Flag.UserId = Convert.ToString(dataList.Cast<Logindetails>().ToList().Select(x => x.UserId).First().ToString());
                                    Flag.ReferenceId = Convert.ToInt64(dataList.Cast<Logindetails>().ToList().Select(x => x.ReferenceId).First().ToString());
                                    Flag.UserName = Convert.ToString(dataList.Cast<Logindetails>().ToList().Select(x => x.UserName).First().ToString());
                                    Flag.Password = Convert.ToString(dataList.Cast<Logindetails>().ToList().Select(x => x.Password).First().ToString());
                                    Flag.PasswordKey = Convert.ToString(dataList.Cast<Logindetails>().ToList().Select(x => x.PasswordKey).First().ToString());
                                    Flag.UserCode = Convert.ToString(dataList.Cast<Logindetails>().ToList().Select(x => x.UserCode).First().ToString());
                                    Flag.UserType = Convert.ToString(dataList.Cast<Logindetails>().ToList().Select(x => x.UserType).First().ToString());
                                    Flag.BranchId = Convert.ToInt32(dataList.Cast<Logindetails>().ToList().Select(x => x.BranchId).First().ToString());
                                    Flag.BranchName = Convert.ToString(dataList.Cast<Logindetails>().ToList().Select(x => x.BranchName).First().ToString());
                                    Flag.IsDefaultPswdChange = Convert.ToString(dataList.Cast<Logindetails>().ToList().Select(x => x.IsDefaultPswdChange).First().ToString());
                                    Flag.LastLogin = Convert.ToString(dataList.Cast<Logindetails>().ToList().Select(x => x.LastLogin).First().ToString());
                                    Flag.IsActive = Convert.ToString(dataList.Cast<Logindetails>().ToList().Select(x => x.IsActive).First().ToString());
                                    Flag.IsDeleted = Convert.ToString(dataList.Cast<Logindetails>().ToList().Select(x => x.IsDeleted).First().ToString());
                                    Flag.CreatedBy = Convert.ToInt64(dataList.Cast<Logindetails>().ToList().Select(x => x.CreatedBy).First().ToString());
                                    Flag.CreatedOn = Convert.ToDateTime(dataList.Cast<Logindetails>().ToList().Select(x => x.CreatedOn).First().ToString());
                                    #endregion
                                    Flag.Flag = "1";
                                    common.Add(Flag);
                                }
                                else
                                {
                                    Flag.Flag = "0";
                                    Flag.FlagValue = "User already logged on. Either Try logging in after closing the current session or Try after some time!!";
                                    common.Add(Flag);
                                }
                            }
                        }
                    }
                    else
                    {
                        Flag.Flag = "0";
                        Flag.FlagValue = "Invalid User!!";
                        common.Add(Flag);
                    }
                }
                return common;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private static string GetIpAddress()  // Get IP Address
        {
            IPHostEntry ipEntry = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress[] addr = ipEntry.AddressList;
            return addr[1].ToString();
        }
        private static string GetMacAddress()
        {
            string macAddresses = string.Empty;

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    macAddresses += nic.GetPhysicalAddress().ToString();
                    break;
                }
            }
            return macAddresses;
        }
    }

}