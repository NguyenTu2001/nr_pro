using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication2.Controllers
{
    [RoutePrefix("api/admin")]

    public class Test1Controller : ApiController
    {
        [Route("test")]
        [HttpGet]
        // GET: Test
        public IHttpActionResult Index()
        {
            return Ok("aaa");
        }

    }
    
}
