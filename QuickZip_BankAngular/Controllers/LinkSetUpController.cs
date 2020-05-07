using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using QuickZip_BankAngular.Models;
using System.Threading.Tasks;

namespace QuickZip_BankAngular.Controllers
{
    public class LinkSetUpController : ApiController
    {
        LinkSetUpDataAccessLayer objlinkSetUp = new LinkSetUpDataAccessLayer();

        [HttpGet]
        [Route("api/LinkSetUp/BindParentMenu")]
        public Dictionary<string, object> BindParentMenu()
        {
            return objlinkSetUp.BindParentMenu();
        }

        [HttpGet]
        [Route("api/LinkSetUp/BindIconName")]
        public Dictionary<string, object> BindIconName()
        {
            return objlinkSetUp.BindIconName();
        }

        [HttpGet]
        [Route("api/LinkSetUp/Index")]
        public Dictionary<string, object> Index()
        {
            return objlinkSetUp.GetAllLinkSetUps();
        }

        [HttpPost]
        [Route("api/LinkSetUp/Create/{UserId}")]
        public IEnumerable<LinkSetUp> Create([FromBody] LinkSetUp LinkSetUp, string UserId)
        {
            return objlinkSetUp.AddLinkSetUp(LinkSetUp, UserId);
        }
        [HttpDelete]
        [Route("api/LinkSetUp/Delete/{id}/{CreatedBy}")]
        public IEnumerable<ParentMenuMaster> Delete(string id,string CreatedBy)
        {
            return objlinkSetUp.DeleteParentMenu(id,CreatedBy);
        }
        [HttpPost]
        [Route("api/LinkSetUp/Edit/{id}/{Userid}")]
        public IEnumerable<LinkSetUp> Edit([FromBody] LinkSetUp linkSetUp,string id,string Userid)
        {
            return objlinkSetUp.EditLinkSetUp(linkSetUp,id,Userid);
        }


        [HttpPost]
        [Route("api/LinkSetUp/CreateMaster/{UserId}")]
        public IEnumerable<LinkSetUp> CreateMaster([FromBody] LinkSetUp LinkSetUp, string UserId)
        {
            return objlinkSetUp.AddLinkSetUpMaster(LinkSetUp, UserId);
        }
       
        [HttpPost]
        [Route("api/LinkSetUp/EditMaster/{id}/{Userid}")]
        public IEnumerable<LinkSetUp> EditMaster([FromBody] LinkSetUp linkSetUp, string id, string Userid)
        {
            return objlinkSetUp.EditLinkSetUpMaster(linkSetUp, id, Userid);
        }
    }
}