using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LTW05_BTTL2.Models
{
    public class Department
    {
        public int ID { get; set; }
        public string RoomName { get; set; }
        public int EmployeeCount { get; set; }
    }
}