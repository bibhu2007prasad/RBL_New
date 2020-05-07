using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Newtonsoft.Json;
using BusinessLibrary;
using QuickZip_BankAngular.Entity;
using System.Threading.Tasks;

namespace QuickZip_BankAngular.Models
{
    public class LinkSetUpDataAccessLayer
    {
        //AngularTestdatabaseEntities context = new AngularTestdatabaseEntities();
        Demo2_ZipNach_RBLBank_AngularEntities context = new Demo2_ZipNach_RBLBank_AngularEntities();
        List<LinkSetUp> dataList = new List<LinkSetUp>();
        List<ParentMenuMaster> dataList1 = new List<ParentMenuMaster>();

        public Dictionary<string, object> BindParentMenu()
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_LinkSetup_AccessRights]").With<ParentMenuMaster>().Execute("@QueryType", "BindParentMenu"));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> BindIconName()
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_LinkSetup_AccessRights]").With<IconNameMaster>().Execute("@QueryType", "GetIcons"));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Dictionary<string, object> GetAllLinkSetUps()
        {
            try
            {
                var Result = Common.Getdata(context.MultipleResults("[dbo].[Sp_LinkSetup_AccessRights]").With<LinkSetUp>().Execute("@QueryType","BindGridLinkItems"));
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //To Add new employee record 
        public IEnumerable<LinkSetUp> AddLinkSetUp(LinkSetUp linkSetUp, string UserId)
        {
            try
            {
                string isDeleted = "0";
                string isActive = (linkSetUp.IsActive == true) ? "1" : "1";
               // string isActive = (linkSetUp.IsActive == "true") ? "1" : "0";


                var Result = context.MultipleResults("[dbo].[Sp_LinkSetup_AccessRights]").With<LinkSetUp>().Execute("@QueryType", "@LinkName", "@url", "@Purpose", "@IconName", "@OrderNo", "@IsActive", "@Createdby",
                                                                "SaveParentMenu", linkSetUp.LinkName, linkSetUp.url, linkSetUp.Purpose,linkSetUp.IconName,Convert.ToString(linkSetUp.OrderNo),isActive, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))));
                foreach (var _holiday in Result)
                {
                    //Flag = employe.Cast<ResFlag>().ToList() .Select(x=>x.Responseflag).First().ToString();
                    dataList = _holiday.Cast<LinkSetUp>().ToList();
                }
                return dataList;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<LinkSetUp> EditLinkSetUp(LinkSetUp linkSetUp,string id, string UserId)
        {
            try
            {
                var Result = context.MultipleResults("[dbo].[Sp_LinkSetup_AccessRights]").With<LinkSetUp>().Execute("@QueryType", "@LinkName", "@LinkID", "@Createdby",
                                                                "UpdateParentMenu", linkSetUp.LinkName,id, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))));
                foreach (var _holiday in Result)
                {
                    //Flag = employe.Cast<ResFlag>().ToList() .Select(x=>x.Responseflag).First().ToString();
                    dataList = _holiday.Cast<LinkSetUp>().ToList();
                }
                return dataList;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //To Delete the record on a particular employee
        public IEnumerable<ParentMenuMaster> DeleteParentMenu(string LinkID,string UserId)
        {
            try
            {
                var Result = context.MultipleResults("[dbo].[Sp_LinkSetup_AccessRights]").With<ParentMenuMaster>().Execute("@QueryType", "@LinkID", "@Createdby",
                                                               "DeleteParentMenu", LinkID, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))));
                foreach (var _holiday in Result)
                {
                    dataList1 = _holiday.Cast<ParentMenuMaster>().ToList();
                }
                return dataList1;
            }
            catch
            {
                throw;
            }
        }


        //To Update new employee record 
        public IEnumerable<LinkSetUp> UpadateParentMenu(ParentMenuMaster parentMenuMaster, string UserId)
        {
            try
            {
                
                var Result = context.MultipleResults("[dbo].[Sp_LinkSetup_AccessRights]").With<ParentMenuMaster>().Execute("@QueryType", "@LinkName", "@LinkID", "@Createdby",
                                                                "UpdateParentMenu",parentMenuMaster.LinkName, Convert.ToString(parentMenuMaster.LinkID), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))));
                foreach (var _holiday in Result)
                {
                    dataList = _holiday.Cast<LinkSetUp>().ToList();
                }
                return dataList;
            }
            catch
            {
                throw;
            }
        }
        //To Add new employee record 
        public IEnumerable<LinkSetUp> AddLinkSetUpMaster(LinkSetUp linkSetUp, string UserId)
        {
            try
            {
                string isDeleted = "0";
                string isActive = (linkSetUp.IsActive == true) ? "1" : "0";
                string isDefault = (linkSetUp.IsDefault == true) ? "1" : "0";
                // string isActive = (linkSetUp.IsActive == "true") ? "1" : "0";


                var Result = context.MultipleResults("[dbo].[Sp_LinkSetup_AccessRights]").With<LinkSetUp>().Execute("@QueryType", "@LinkName", "@url", "@Purpose", "@IconName", "@OrderNo", "@IsActive", "@Createdby", "@ParentMenuId", "@IsDefault",
                                                                "InsertLinks", linkSetUp.LinkName, linkSetUp.url, linkSetUp.Purpose, linkSetUp.IconName, Convert.ToString(linkSetUp.OrderNo), isActive, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), Convert.ToString(linkSetUp.ParentMenuId), isDefault);
                foreach (var _holiday in Result)
                {
                    //Flag = employe.Cast<ResFlag>().ToList() .Select(x=>x.Responseflag).First().ToString();
                    dataList = _holiday.Cast<LinkSetUp>().ToList();
                }
                return dataList;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IEnumerable<LinkSetUp> EditLinkSetUpMaster(LinkSetUp linkSetUp, string id, string UserId)
        {
            try
            {
                string isDeleted = "0";
                string isActive = (linkSetUp.IsActive == true) ? "1" : "0";
                string isDefault = (linkSetUp.IsDefault == true) ? "1" : "0";
                // string isActive = (linkSetUp.IsActive == "true") ? "1" : "0";
                var Result = context.MultipleResults("[dbo].[Sp_LinkSetup_AccessRights]").With<LinkSetUp>().Execute("@QueryType", "@LinkName", "@url", "@Purpose", "@IconName", "@OrderNo", "@IsActive", "@LinkID", "@ParentMenuId", "@IsDefault",
                                                                "UpDateLinks", linkSetUp.LinkName,linkSetUp.url,linkSetUp.Purpose,linkSetUp.IconName, Convert.ToString(linkSetUp.OrderNo), isActive, id, Convert.ToString(linkSetUp.ParentMenuId),isDefault);
                foreach (var _holiday in Result)
                {
                    //Flag = employe.Cast<ResFlag>().ToList() .Select(x=>x.Responseflag).First().ToString();
                    dataList = _holiday.Cast<LinkSetUp>().ToList();
                }
                return dataList;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }


}