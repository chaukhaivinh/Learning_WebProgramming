using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LTW03_BTTL5.Models
{
    public class Sach
    {
        public int MaSach { get; set; }
        public string TenSach { get; set; }
        public decimal Gia { get; set; }
        public string AnhBia { get; set; }
        public Sach() { }
        public Sach(int maSach, string tenSach, decimal gia, string anhBia)
        {
            MaSach = maSach;
            TenSach = tenSach;
            Gia = gia;
            AnhBia = anhBia;
        }
    }
}