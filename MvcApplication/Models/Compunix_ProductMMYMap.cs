using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication.Models
{
    public class Compunix_ProductMMYMap: ClassMap<Compunix_ProductMMY>
    {
        public Compunix_ProductMMYMap()
        {
            Map(x=>x.MMYID);
            Map(x=>x.ProductID);
            Map(x=>x.VariantID);
            Id(x => x.PMMYID);
        }
    }
}