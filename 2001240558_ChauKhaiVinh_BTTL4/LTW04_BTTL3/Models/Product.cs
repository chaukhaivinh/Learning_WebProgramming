using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LTW04_BTTL3.Models
{
    public class Product
    {
        public string TenSP { get; set; }
        public decimal Gia { get; set; }
        public int MaLoai { get; set; }

        public Product() { }

        public Product(string tenSP, decimal gia, int maLoai)
        {
            TenSP = tenSP;
            Gia = gia;
            MaLoai = maLoai;
        }
    }
}