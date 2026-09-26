using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LTW_BTTL2.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string DisplayName  { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public int DepartmentID { get; set; }
    }
}