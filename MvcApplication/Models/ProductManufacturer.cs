using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication.Models
{
    public class ProductManufacturer
    {
      public virtual int ProductID { get; set; }
      public virtual int ManufacturerID { get; set; }
      public virtual Product ProductFor {get;set;}
      public virtual Manufacturer ManufacturerFor {get;set;}
      public virtual int DisplayOrder {get;set;}
      public virtual string CreatedOn {get;set;}

      //public override bool Equals(object obj)
      //{
      //    return false;
      //}

      //public override int GetHashCode()
      //{
      //    return (ManufacturerID + "|" +
      //    ProductID).GetHashCode();
      //}
    }
}