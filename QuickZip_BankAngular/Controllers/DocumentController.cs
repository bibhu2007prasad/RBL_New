using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuickZip_BankAngular.Models;
using System.Threading.Tasks;

namespace QuickZip_BankAngular.Controllers
{
    public class DocumentController : ApiController
    {
        DocumentDataAccessLayer objdocument = new DocumentDataAccessLayer();
        [HttpGet]
        [Route("api/Document/Index/{UserId}/{EntityId}")]
        public Dictionary<string, object> Index(string UserId, string EntityId)
        {
            return objdocument.GetAllDocuments(UserId,EntityId);
        }

        [HttpPost]
        [Route("api/Document/Create/{UserId}/{EntityId}")]
        public IEnumerable<Document> Create([FromBody] Document Document, string UserId, string EntityId)
        {
            return objdocument.AddDocument(Document, UserId, EntityId);
        }
        //[HttpDelete]
        //[Route("api/Document/Delete/{id}")]
        //public IEnumerable<Document> Delete(int id)
        //{
        //    return objdocument.DeleteDocument(id);
        //}
        [HttpPost]
        [Route("api/Document/Edit/{UserId}/{EntityId}/{id}")]
        public IEnumerable<Document> Edit([FromBody] Document Document, string UserId, string EntityId, int id)
        {
            return objdocument.EditDocument(Document,UserId,EntityId,id);
        }
    }
}