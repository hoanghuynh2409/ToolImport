using MvcApplication.Models;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Dialect;
using NHibernate.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcApplication.Controllers
{
    public class ValuesController : ApiController
    {
        public IEnumerable<AllRowImport> Get()
        {
            return DB.listAllRowImport();
        }

        // GET api/values/5
        public AllRowImport Get(int id)
        {
            return DB.getAItemFromAllRowImport(id);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {

        }

        // PUT api/values/5
        public void Put(int id, AllRowImport ari)
        {
            //int i = id;
            //Demos str = d;
            DB.updateAItemOfAllRowImport(id,ari);
        }

        // DELETE api/values/5
        public void DeletePerson(int id)
        {
            DB.deleteAItemOfAllRowImport(id);
        }
    }
}