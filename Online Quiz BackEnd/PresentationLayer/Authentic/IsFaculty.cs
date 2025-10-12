using BusinessLogicLayer.Services;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace PresentationLayer.Authentic
{
    public class IsFaculty: AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var cookie = HttpContext.Current.Request.Cookies["access_token"];
            if(cookie == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized, "Not Faculty") ;
            }
            else if(cookie != null)
            {
                string tk = cookie.Value.ToString();
                int id = AuthServices.ValidateToken(tk);
                if (id == 0)
                {
                    actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized, "Not Faculty");
                }
                else
                {
                    var token = AuthServices.Get(id);
                    if(token.Type != "Faculty")
                    {
                        actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized, "Not Faculty");
                    }
                    else
                    {
                        base.OnAuthorization(actionContext);
                    }
                }
            }
            
        }
    }
}