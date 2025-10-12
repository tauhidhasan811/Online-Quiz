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
    [RoutePrefix("api/student")]
    public class StudentController : ApiController
    {
        [HttpPost]
        [Route("create")]
        public HttpResponseMessage Create(StudentDTO student)
        {
            try
            {
                string message = StudentService.Create(student);
                return Request.CreateResponse(HttpStatusCode.OK, message);
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(ex.Message);
            }
            
        }

        [HttpGet]
        [Route("getall")]
        [LoggedIn]
        public HttpResponseMessage GetAll()
        {
            try
            {
                var students = StudentService.GetAllStudent();
                return Request.CreateResponse(HttpStatusCode.OK, students);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, ex.Message);
            }
        }

        [HttpPut]
        [Route("update")]
        [LoggedIn]
        public HttpResponseMessage Update(StudentDTO student)
        {
            try
            {
                var message = StudentService.Update(student);
                return Request.CreateResponse(HttpStatusCode.OK, message);
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
                var message = StudentService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, message);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, ex.Message);
            }
        }
    }
}
