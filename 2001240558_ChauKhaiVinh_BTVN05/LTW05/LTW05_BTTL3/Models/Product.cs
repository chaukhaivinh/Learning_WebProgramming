using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LTW05_BTTL3.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string DisplayName { get; set; }
        public string Link { get; set; }
        public double Price { get; set; }
        public string Describe { get; set; }
        public int TypeID { get; set; }
    }
}