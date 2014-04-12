using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication.Models
{
    public class NHibertnateSession
    {
        public static ISession OpenSession()
        {
            var configuration = new Configuration();
            var configurationPath = HttpContext.Current.Server.MapPath(@"~\Models\hibernate.cfg.xml");
            configuration.Configure(configurationPath);

            var employeeConfigurationFile = HttpContext.Current.Server.MapPath(@"~\Models\Demos.hbm.xml");
            configuration.AddFile(employeeConfigurationFile);

            var allRowImport = HttpContext.Current.Server.MapPath(@"~\Models\AllRowImport.hbm.xml");
            configuration.AddFile(allRowImport);

            var category = HttpContext.Current.Server.MapPath(@"~\Models\Category.hbm.xml");
            configuration.AddFile(category);

            var manufacturer = HttpContext.Current.Server.MapPath(@"~\Models\Manufacturer.hbm.xml");
            configuration.AddFile(manufacturer);

            var promanufacturer = HttpContext.Current.Server.MapPath(@"~\Models\ProductManufacturer.hbm.xml");
            configuration.AddFile(promanufacturer);

            var Product = HttpContext.Current.Server.MapPath(@"~\Models\Product.hbm.xml");
            configuration.AddFile(Product);
            ISessionFactory sessionFactory = configuration.BuildSessionFactory();
            return sessionFactory.OpenSession();
        }
    }
}