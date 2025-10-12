using BusinessLogicLayer.Services;
using PresentationLayer.Authentic;
using PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Web;
using System.Web.Http;

namespace PresentationLayer.Controllers
{
    [RoutePrefix("api/auth")]
    public class AuthController : ApiController
    {
        [HttpPost]
        [Route("login")]
        public HttpResponseMessage LogIn(UserLog user)
        {
            try
            {
                var data = AuthServices.Authorization(user.UserName, user.Password);
                if (data.UserId > 0)
                {
                    var accesstoken = data.AccessToken;

                    var cookie = new HttpCookie("access_token", accesstoken)
                    {
                        HttpOnly = true,
                        Secure = true,
                        SameSite = SameSiteMode.None,
                        Expires = DateTime.UtcNow.AddDays(1),
                        Path = "/"
                    };
                    HttpContext.Current.Response.Cookies.Add(cookie);


                    var response = new
                    {
                        UserId = data.UserId,
                        Type = data.Type,
                        check = "success"
                    };
                    HttpContext.Current.Response.Cookies.Add(cookie);
                    //string value = HttpContext.Current.Request.Cookies["access_token"].Value;
                    return Request.CreateResponse(HttpStatusCode.OK, response);
                }
                return Request.CreateResponse(HttpStatusCode.Unauthorized, "Invalid username or Password");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            

        }
        [HttpPost]
        [LoggedIn]
        [Route("logout")]
        public HttpResponseMessage LogOut()
        {
            try
            {
                var accesstoken = HttpContext.Current.Request.Cookies["access_token"];
                if (accesstoken != null)
                {
                    var response = AuthServices.Update(accesstoken.Value);
                    HttpContext.Current.Response.Cookies.Remove("access_token");
                }

                return Request.CreateResponse(HttpStatusCode.OK, "response");

            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
            
        }
        [HttpPost]
        [Route("validate")]
        public HttpResponseMessage Validate()
        {
            try
            {
                string accesstoken = HttpContext.Current.Request.Cookies["access_token"]?.Value;
                var token = AuthServices.AlreadyLoggedIn(accesstoken);
                if (token.UserId > 0)
                {
                    var response = new
                    {
                        UserId = token.UserId,
                        Type = token.Type,
                        check = "success"
                    };
                    //string value = HttpContext.Current.Request.Cookies["access_token"].Value;
                    return Request.CreateResponse(HttpStatusCode.OK, response); ;
                }
                return Request.CreateResponse(HttpStatusCode.Unauthorized, "Invalid Token");
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }
    }
}
