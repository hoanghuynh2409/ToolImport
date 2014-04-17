using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication.Models
{
    public class ProductCategoryMap: ClassMap<ProductCategory>
    {
        public ProductCategoryMap()
        {
            CompositeId().KeyProperty(x => x.CreatedOn, "CreatedOn");
            References(x => x.Product).Column("ProductID").Cascade.All();
            References(x => x.Category).Column("CategoryID").Cascade.All();
            Map(x => x.DisplayOrder);
        }
    }
}