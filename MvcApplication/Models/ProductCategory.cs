using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication.Models
{
    public class ProductCategory
    {
      public virtual int ProductID {get;set;}
      public virtual int CategoryID {get;set;}
      public virtual int DisplayOrder {get;set;}
      public virtual DateTime CreatedOn {get;set;}
    }
}