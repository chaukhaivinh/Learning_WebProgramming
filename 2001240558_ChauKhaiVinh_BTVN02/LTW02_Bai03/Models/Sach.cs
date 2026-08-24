using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LTW02_Bai03.Models
{
    public class Sach
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Image { get; set; }
        public int IDType { get; set; }
        public Sach(int _ID, string _Name, float _Price, string _Image, int _IDType)
        {
            ID = _ID;
            Name = _Name;
            Price = _Price;
            Image = _Image;
            IDType = _IDType;
        }
    }
}