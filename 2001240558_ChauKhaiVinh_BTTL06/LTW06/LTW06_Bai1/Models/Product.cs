using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LTW06_Bai1.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string DisplayName { get; set; }
        public int TypeID { get; set; }
        public int ManuID { get; set; }
        public double Price { get; set; }
        public string Note { get; set; }
        public string Image { get; set; }
    }
}