using MvcApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcApplication.Controllers
{
    public class ImportdataController : ApiController
    {
        DB db = new DB();
        // GET api/importdata
        public IEnumerable<string> Get()
        {
            db.ImportData();
            return new string[] { "value1", "value2" };
        }

        // GET api/importdata/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/importdata
        public void Post([FromBody]string value)
        {
        }

        // PUT api/importdata/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/importdata/5
        public void Delete(int id)
        {
        }
    }
}
