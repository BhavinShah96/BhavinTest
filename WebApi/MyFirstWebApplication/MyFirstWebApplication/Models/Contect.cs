using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstWebApplication.Models
{
    public class Contect
    {
        public Guid ID { get; set; }
        public string  Name { get; set; }
        public int MobileNo { get; set; }
        public string Address { get; set; }
    }
}