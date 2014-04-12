using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication.Models
{
    public class Compunix_ProductMMY
    {
      public virtual int MMYID {get;set;}
      public virtual int ProductID {get;set;}
      public virtual int VariantID {get;set;}
      public virtual int? PMMYID {get;set;}
    }
}