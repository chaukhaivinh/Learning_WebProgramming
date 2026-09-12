using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LTW04_BTTL3.Models
{
    public class Product
    {
        public string ProductName {  get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
    }
}