using NovaNestBLL.DTOs;
using NovaNestBLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NovaNestAPI.Controllers
{
    [RoutePrefix("api/customer")]
    public class UserController : ApiController
    {
        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage Get(int id)
        {
            var data = CustomerService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("all")]
        public HttpResponseMessage Get()
        {
            var data = CustomerService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpPost]
        [Route("register")]
        public HttpResponseMessage Register(CustomerDTO c)
        {
            CustomerService.Create(c);
            return Request.CreateResponse(HttpStatusCode.OK, "Customer Registered");
        }


    }
}
