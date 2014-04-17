using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication.Models
{
    public class Compunix_MakeModelYearMap:ClassMap<Compunix_MakeModelYear>
    {
        public Compunix_MakeModelYearMap()
        {
            Id(x=>x.MMYID);
            Map(x=>x.Make);
            Map(x=>x.Model);
            Map(x=>x.Year);
        }
    }
}