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
        // GET api/values
        //public IEnumerable<Demos> Get()
        //public string Get()
        public void Get()
        {
            //var r = new Random();
            //var items = Enumerable.Range(1, 50).Select(o => new AngularJSMVC.Models.Demo
            //{
            //    Id = o,
            //    Brith = new DateTime(2014, r.Next(1, 12), r.Next(1, 28)).ToShortDateString(),
            //    Age = (int)r.Next(10),
            //    Name = "abc " + o.ToString()
            //}).ToArray();
            //return items;

            //using (ISession session = NHibertnateSession.OpenSession())
            //{
            //    var q = session.CreateCriteria<Demos>().List<Demos>();//.Select(c => new { c.Id, c.Name,c.Age,c.Brith}).ToList();
            //    return q;
            //}

            //return DB.checkExistProduct("Eline Series OE Replacement Brake Rotors1", "Eline Series");
            //return DB.insertNewProduct("abc", "a aa a ", "xml.package", "ok", "m", "", "PS4F551");
            //return DB.checkExistManufacturer("Eline Series1");
            //return DB.insertManufacturer("Eline Series1123");
            // DB.deleteProductManufurer(168504);
            DB.insertProductManufurer(168400, 81);
        }

        // GET api/values/5
        public Demos Get(int id)
        {
            using (ISession session = NHibertnateSession.OpenSession())
            {
                    var demo = session.Load<Demos>(id);
                    return demo;        
            }
        }

        // POST api/values
        public void Post([FromBody]string value)
        {

        }

        // PUT api/values/5
        public void Put(int id, Demos d)
        {
            //int i = id;
            //Demos str = d;
            using (ISession session = NHibertnateSession.OpenSession())
            {
                using (ITransaction Transaction = session.BeginTransaction())
                {
                    var demo = session.Load<Demos>(id);
                    demo.Name = d.Name;
                    session.SaveOrUpdate(demo);
                    Transaction.Commit();
                }

            }
        }

        // DELETE api/values/5
        public void DeletePerson(int id)
        {
            using (ISession session = NHibertnateSession.OpenSession())
            {
                using (ITransaction Transaction = session.BeginTransaction())
                {
                    var demo = session.Load<Demos>(id);
                    session.Delete(demo);
                    Transaction.Commit();
                }

            }
        }
    }
}