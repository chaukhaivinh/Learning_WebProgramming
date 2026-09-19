using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LTW05_BTM1.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public int DepID { get; set; }
    }
}