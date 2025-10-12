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
    [RoutePrefix("api/question")]
    public class QuestionController : ApiController
    {
        [HttpPost]
        [Route("create")]
        [IsFaculty]
        [LoggedIn]
        public HttpResponseMessage Create(QuestionDTO questions)
        {
            try
            {
                int response = QuestionService.Create(questions);
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpGet]
        [Route("getall/{quzid}")]
        [LoggedIn]
        public HttpResponseMessage Get(int quzid)
        {
            try
            {
                var response = QuestionService.GetByQuizId(quzid);
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpPut]
        [Route("update")]
        [LoggedIn]
        public HttpResponseMessage Update(QuestionDTO questions)
        {
            try
            {
                var response = QuestionService.Update(questions);
                if (response)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Updated");
                }
                return Request.CreateResponse(HttpStatusCode.OK, "Failed");
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpGet]
        [Route("get/{id}")]
        [LoggedIn]
        public HttpResponseMessage GetById(int id)
        {
            try
            {
                var response = QuestionService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpDelete]
        [Route("delete/{id}")]
        [LoggedIn]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var response = QuestionService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
