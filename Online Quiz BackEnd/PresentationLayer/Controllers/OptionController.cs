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
    [RoutePrefix("api/option")]
    public class OptionController : ApiController
    {
        [HttpPost]
        [Route("create")]
        [IsFaculty]
        [LoggedIn]
        public HttpResponseMessage Create(OptionDTO option)
        {
            try
            {
                var check = OptionService.Create(option);
                if (check)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Added");
                }
                return Request.CreateResponse(HttpStatusCode.OK, "Failed");
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [Route("getall")]
        [HttpGet]
        [IsFaculty]
        [LoggedIn]
        public HttpResponseMessage GetALL()
        {
            try
            {
                var options = OptionService.GetALL();
                return Request.CreateResponse(HttpStatusCode.OK, options);
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }
        [Route("getbyques/{qid}")]
        [HttpGet]
        [LoggedIn]
        public HttpResponseMessage GetByQuesId(int qid)
        {
            try
            {
                var options = OptionService.GetByQuesId(qid);
                return Request.CreateResponse(HttpStatusCode.OK, options);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [Route("update")]
        [IsFaculty]
        [LoggedIn]
        [HttpPut]
        public HttpResponseMessage Update(OptionDTO option)
        {
            try
            {
                var options = OptionService.Update(option);
                if (options)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Updated");
                }
                return Request.CreateResponse(HttpStatusCode.OK, "Failed");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [Route("get/{id}")]
        [IsFaculty]
        [LoggedIn]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var option = OptionService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, option);
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, ex.Message);
            }
        }
        [Route("delete/{id}")]
        [IsFaculty]
        [LoggedIn]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var option = OptionService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, option);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, ex.Message);
            }
        }
    }
}
