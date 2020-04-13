using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Net.Http;
using System.Web.Http;
using QuickZip_BankAngular.Models.Login;
using QuickZip_BankAngular.Models;

namespace QuickZip_BankAngular.Controllers
{
    public class LoginController : ApiController
    {
        Login objlogin = new Login();
        [HttpGet]
        [Route("api/Login/getlogindetails/{Username}/{Password}")]
        public IEnumerable<CommonFlag> getlogindetails(string Username, string Password)
        {
            return objlogin.Binddetails(Username, Password);
        }

    }
}