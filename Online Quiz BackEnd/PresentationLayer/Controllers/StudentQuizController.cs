using BusinessLogicLayer.Services;
using PresentationLayer.Authentic;
using PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PresentationLayer.Controllers
{
    [RoutePrefix("api/studentquiz")]
    public class StudentQuizController : ApiController
    {

        [Route("create")]
        [HttpPost]
        [LoggedIn]
        public HttpResponseMessage Create(studentquiz squiz)
        {
            try
            {
                int squizid = StudentQuizService.Create(squiz.StudentId, squiz.QuizId);
                return Request.CreateResponse(HttpStatusCode.OK, squizid);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("update")]
        [HttpPost]
        [LoggedIn]
        public HttpResponseMessage Update(studentquizUpdate squiz)
        {
            {
                try
                {
                    int mark = 0;
                    if (squiz.answers.Count != 0)
                    {
                        mark = OptionService.Iscorrect(squiz.answers);
                    }

                    float message = StudentQuizService.Update(squiz.squizid, mark);
                    return Request.CreateResponse(HttpStatusCode.OK, message);
                }
                catch (Exception ex)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
                }
            }
        }
        [Route("getbystudentid/{sid}")]
        [HttpGet]
        [LoggedIn]
        public HttpResponseMessage GetByStudentId(int sid)
        {
            try
            {
                var squizzes = StudentQuizService.GetByStudentId(sid);
                return Request.CreateResponse(HttpStatusCode.OK, squizzes);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

    }
}
