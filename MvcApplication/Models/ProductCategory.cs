using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication.Models
{
    public class ProductCategory
    {
      public virtual Product Product {get;set;}
      public virtual Category Category {get;set;}
      public virtual int DisplayOrder {get;set;}
      public virtual string CreatedOn {get;set;}
      public override bool Equals(object obj)
      {
          return true;
      }

      public override int GetHashCode()
      {
          return 0;
      }
    }
}