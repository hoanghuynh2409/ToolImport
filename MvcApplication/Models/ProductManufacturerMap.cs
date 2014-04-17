using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication.Models
{
    public class ProductManufacturerMap:ClassMap<ProductManufacturer>
    {
        public ProductManufacturerMap()
        {
            CompositeId().KeyProperty(x => x.CreatedOn, "CreatedOn");
            References(x => x.ProductFor).Column("ProductID").Cascade.All();
            References(x => x.ManufacturerFor).Column("ManufacturerID").Cascade.All();
            Map(x => x.DisplayOrder);
        }
    }
}