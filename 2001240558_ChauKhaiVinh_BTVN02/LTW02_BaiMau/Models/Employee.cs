using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc.Routing.Constraints;

namespace LTW02_BaiMau.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }
        public Employee() 
        {
            ID = 2001240558;
            Name = "Châu Khải Vinh";
            Address = "140 LEee Trọng Tấn";
            Salary = 100000000;
        }
    }
}