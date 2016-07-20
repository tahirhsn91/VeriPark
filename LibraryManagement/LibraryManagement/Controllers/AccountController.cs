using LibraryManagement.Common.Helpers;
using LibraryManagement.Core.Entities;
using LibraryManagement.Core.IService;
using LibraryManagement.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Security;

namespace LibraryManagement.Controllers
{
    [RoutePrefix("api/Account")]
    public class AccountController : ApiController
    {
        IAccountService service;

        public AccountController()
        {
            service = new AccountService();
        }

        [HttpPost]
        [Route("Login")]
        public void Login(Login data)
        {
            if (service.ValidateUser(data))
            {
                FormsAuthentication.SetAuthCookie(data.UserName, false);
            }
            else
            {
                ExceptionHelper.ThrowAPIException(HttpStatusCode.Unauthorized, "UserName Or Password is Incorrect", "UserName Or Password is Incorrect");
            }
        }

        [HttpPost]
        [Route("SignOut")]
        public void SignOut()
        {
            FormsAuthentication.SignOut();
        }
    }
}
