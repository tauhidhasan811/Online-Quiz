using BusinessLogicLayer.DTO;
using BusinessLogicLayer.Services;
using PresentationLayer.Authentic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace PresentationLayer.Controllers
{
    [RoutePrefix("api/faculty")]
    public class FacultyController : ApiController
    {
        [HttpPost]
        [Route("create")]
        public HttpResponseMessage Create(FacultyDTO quz)
        {
            try
            {
                string message = FacultyService.Create(quz);
                return Request.CreateErrorResponse(HttpStatusCode.OK, message);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [Route("getall")]
        [LoggedIn]
        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            try
            {
                //var cookies = HttpContext.Current.Request.Cookies["access_token"];
                var faculties = FacultyService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, faculties);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, ex.Message);
            }
        }
        [Route("update")]
        [LoggedIn]
        [HttpPut]
        public HttpResponseMessage Update(FacultyDTO faculty)
        {
            try
            {
                //var cookies = HttpContext.Current.Request.Cookies["access_token"];
                var faculties = FacultyService.Update(faculty);
                return Request.CreateResponse(HttpStatusCode.OK, faculties);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, ex.Message);
            }
        }

        [HttpDelete]
        [Route("delete/{id}")]
        [LoggedIn]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var message = FacultyService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, message);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, ex.Message);
            }
        }

    }
}
