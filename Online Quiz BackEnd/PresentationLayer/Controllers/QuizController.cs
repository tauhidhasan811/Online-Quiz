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
    [RoutePrefix("api/quiz")]
    public class QuizController : ApiController
    {
        [HttpPost]
        [Route("create")]
        [LoggedIn]
        [IsFaculty]
        public HttpResponseMessage Create(QuizDTO quz)
        {
            try
            {
                int id = QuizService.Create(quz);
                var message = new
                {
                    quizid = id,
                    status = "success"
                };

                return Request.CreateResponse(HttpStatusCode.OK, message);
            }
            catch(Exception ex)
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
                var quizzes = QuizService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, quizzes);
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, ex.Message);
            }
        }
        [HttpGet]
        [Route("details/{id}")]
        [LoggedIn]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var quiz = QuizService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, quiz);
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, ex.Message);
            }
        }
        [HttpGet]
        [Route("getbyfaculty/{fid}")]
        [LoggedIn]
        [IsFaculty]
        public HttpResponseMessage GetByFaculty(int fid)
        {
            try
            {
                var quizzes = QuizService.GetByFacultyId(fid);
                return Request.CreateResponse(HttpStatusCode.OK, quizzes);
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, ex.Message);
            }
        }
        [HttpDelete]
        [Route("delete/{qid}")]
        [LoggedIn]
        [IsFaculty]
        public HttpResponseMessage Delete(int qid)
        {
            try
            {
                var quizzes = QuizService.Delete(qid);
                return Request.CreateResponse(HttpStatusCode.OK, quizzes);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, ex.Message);
            }
        }
        [HttpGet]
        [Route("search/{title}")]
        public HttpResponseMessage Search(string title)
        {
            try
            {
                var quiz = QuizService.SearchQuiz(title);
                return Request.CreateResponse(HttpStatusCode.OK, quiz);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, ex.Message);
            }
        }
        [HttpGet]
        [Route("search")]
        public HttpResponseMessage Search(int fid, string title)
        {
            try
            {
                var quiz = QuizService.SearchQuizFidTitle(fid, title);
                return Request.CreateResponse(HttpStatusCode.OK, quiz);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, ex.Message);
            }
        }
    }
}
