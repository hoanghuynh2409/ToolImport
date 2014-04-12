using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication.Models
{
    public class Compunix_MakeModelYear
    {
      public virtual int? MMYID {get;set;}
      public virtual string Make {get;set;}
      public virtual string Model {get;set;}
      public virtual string Year {get;set;}
    }
}