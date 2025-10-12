using BusinessLogicLayer.DTO;
using BusinessLogicLayer.Services;
using PresentationLayer.Authentic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PresentationLayer.Controllers
{
    [RoutePrefix("api/course")]
    public class CourseController : ApiController
    {
        [HttpPost]
        [Route("create")]
        [LoggedIn]
        public HttpResponseMessage Create(CourseDTO course)
        {
            try
            {
                string message = CourseService.Create(course);
                return Request.CreateErrorResponse(HttpStatusCode.OK, message);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [Route("getall")]
        [HttpGet]
        [LoggedIn]
        public HttpResponseMessage GetAll()
        {
            try
            {
                var courses = CourseService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, courses);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, ex.Message);
            }
        }
    }
}
