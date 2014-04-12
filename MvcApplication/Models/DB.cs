using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication.Models
{
    public class DB
    {
        // method return productID
        public static int checkExistProduct(string productName, string manufacturerName)
        {
            using (ISession session = NHibertnateSession.OpenSession())
            {
                Manufacturer m = null;
                Product p = null;
                ProductManufacturer pm = null;
                var result = session.QueryOver<ProductManufacturer>(() => pm)
                    .JoinAlias(() => pm.ProductFor, () => p)
                    .JoinAlias(() => pm.ManufacturerFor, () => m)
                    .Where(() => p.Deleted == 0 && p.Name == productName && m.Name == manufacturerName)
                    .Select(c => pm.ProductID).List<int>();
                return (result.Count() > 0 ? result[0] : 0);
            }
        }


    }
}