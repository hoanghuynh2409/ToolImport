using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication.Models
{
    public class Demos
    {
        public virtual int? Id { get; set; }
        public virtual string Name { get; set; }
        public virtual int Age { get; set; }
        public virtual DateTime Brith { get; set; }
    }
}