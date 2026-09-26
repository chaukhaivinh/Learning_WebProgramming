using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LTW06_Bai1.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string DisplayName { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
    }
}