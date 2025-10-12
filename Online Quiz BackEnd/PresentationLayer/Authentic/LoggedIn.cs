using BusinessLogicLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace PresentationLayer.Authentic
{
    public class LoggedIn: AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var cookies = HttpContext.Current.Request.Cookies["access_token"];
            if (cookies == null )
            {
                //base.OnAuthorization(actionContext);
                actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized, "Do not find any access token");
            }
            else if (cookies.Value == null || AuthServices.ValidateToken(cookies.Value) <= 0)
            {
                actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized, "Do not find any access token or Invalid token");
            }
            base.OnAuthorization(actionContext);
        }
    }
}