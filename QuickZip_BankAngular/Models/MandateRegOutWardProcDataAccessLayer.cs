using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using BusinessLibrary;
using QuickZip_BankAngular.Entity;
using System.Threading.Tasks;

namespace QuickZip_BankAngular.Models
{
    public class MandateRegOutWardProcDataAccessLayer
    {
        Demo2_ZipNach_RBLBank_AngularEntities dbcontext = new Demo2_ZipNach_RBLBank_AngularEntities();
        List<ProcessMandatesOutWard> dataList = new List<ProcessMandatesOutWard>();
        List<CorporateProcOutWard> dataList1 = new List<CorporateProcOutWard>();
        List<SponserBankProcOutWard> dataList2 = new List<SponserBankProcOutWard>();

        public Dictionary<string, object> BankBind(string UserId, string EntityId)
        {
            try
            {
                var result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_Mandate]").With<SponserBankProcOutWard>().Execute("@QueryType", "@UserId", "@EntityId", "UserBank", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%")))));
                //foreach (var dt in Data)
                //{
                //    dataList2 = dt.Cast<SponserBankUnProcOutWard>().ToList();
                //}
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Dictionary<string, object> GetUserCorpData(string EntityId)
        {
            try
            {
                var result = Common.Getdata(dbcontext.MultipleResults("[dbo].[Sp_DownloadMandate]").With<CorporateProcOutWard>().Execute("@QueryType", "@EntityId", "BindCorporate", DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(EntityId.Replace("_", "%")))));
                //foreach (var dt in Data)
                //{
                //    dataList2 = dt.Cast<SponserBankUnProcOutWard>().ToList();
                //}
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //search by Reference

        public IEnumerable<ProcessMandatesOutWard> SearchData(string FromDate, string ToDate, string sponserbankcode, string UserId, string EntityId, string Reference, string ActivityID)
        {
            try
            {
                sponserbankcode = (sponserbankcode == "0" ? "" : sponserbankcode);
                EntityId = (EntityId == "0" ? "" : EntityId);
                Reference = (Reference == "0" ? "" : Reference);
                ActivityID = (ActivityID == "0" ? "" : ActivityID);

                var Result = dbcontext.MultipleResults("[dbo].[Sp_DownloadMandate]").With<ProcessMandatesOutWard>().Execute("@QueryType", "@strToDate", "@strFromDate", "@UserId", "@SponsorBankCode", "@EntityId", "@IsEntity", "@Refrence1", "@ActivityId", "grdMandateDateWiseUMRNConifmred", ToDate, FromDate, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), sponserbankcode, EntityId, "1", Reference, ActivityID);
                foreach (var dt in Result)
                {
                    dataList = dt.Cast<ProcessMandatesOutWard>().ToList();

                }
                return dataList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //public IEnumerable<OldMandateAttribute> RejectData(string strFromDate, string strToDate, string RejectedReason, string UserId, string strTable)
        //{
        //    string[] mandatearr = strTable.Split(',');

        //    //int[] values = { 1, 2, 17, 8 };

        //    XDocument doc = new XDocument();
        //    doc.Add(new XElement("dtXml", mandatearr.Select(x => new XElement("MandateId", x))));










        //    DataTable dt = new DataTable();
        //    dt.Columns.Add("MandateId", typeof(Int64));
        //    // Boolean IsFound = false;

        //    for (int i = 0; i < mandatearr.Length; i++)
        //    {
        //        DataRow dr = dt.NewRow();

        //        // dr = IsMandateID;
        //        dt.Rows.Add(mandatearr[i]);

        //        // dt.Rows.Add(dr);
        //        //IsFound = true;
        //        // }
        //        //}



        //    }
        //    string strTable1 = GetXmlByDatable(dt);


        //    try
        //    {
        //        var Data = dbcontext.MultipleResults("[dbo].[Sp_Mandate]").With<OldMandateAttribute>().Execute("@QueryType", "@strTable", "@strFromDate", "@strToDate", "@UserId", "@RejectedReason", "RejectdataDateWise", strTable1, strFromDate, strToDate, DbSecurity.Decrypt(HttpContext.Current.Server.UrlDecode(UserId.Replace("_", "%"))), RejectedReason);
        //        foreach (var dt1 in Data)
        //        {
        //            dataList = dt1.Cast<OldMandateAttribute>().ToList();
        //        }
        //        return dataList;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public string GetXmlByDatable(DataTable dtObjectforXml)
        //{
        //    if (dtObjectforXml == null)
        //        return "";
        //    if (dtObjectforXml.Rows.Count == 0)
        //        return "";

        //    if (dtObjectforXml.TableName == "")
        //        dtObjectforXml.TableName = "dtXml";

        //    XmlDocument objectXmlDocument = new XmlDocument();
        //    XmlElement objElement = objectXmlDocument.CreateElement(dtObjectforXml.TableName);

        //    for (int iRecordCounter = 0; iRecordCounter < dtObjectforXml.Rows.Count; iRecordCounter++)
        //    {
        //        // Generate XmlObject and Append Nodes by calling a Child function.
        //        objElement.AppendChild(BuildXmlElement(dtObjectforXml.Rows[iRecordCounter], objectXmlDocument));
        //    }

        //    objectXmlDocument.AppendChild(objElement);
        //    return objectXmlDocument.OuterXml;
        //}

        //private XmlElement BuildXmlElement(DataRow drObjectforXml, XmlDocument objectXmlDocument)
        //{
        //    XmlElement XmlElement = objectXmlDocument.CreateElement(drObjectforXml.Table.TableName);
        //    for (int iColumnCounter = 0; iColumnCounter < drObjectforXml.Table.Columns.Count; iColumnCounter++)
        //    {
        //        XmlElement.SetAttribute(drObjectforXml.Table.Columns[iColumnCounter].ColumnName, Convert.ToString(drObjectforXml[iColumnCounter].ToString()));
        //    }

        //    return XmlElement;
        //}


    }
}