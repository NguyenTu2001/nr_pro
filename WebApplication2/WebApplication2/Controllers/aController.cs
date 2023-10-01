using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication2.Controllers
{
    public class aController : ApiController
    {
        // GET: api/a
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/a/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/a
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/a/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/a/5
        public void Delete(int id)
        {
        }
    }
}
