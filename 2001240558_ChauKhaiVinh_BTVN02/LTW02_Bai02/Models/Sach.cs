using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LTW02_Bai02.Models
{
    public class Sach
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string CoverPhoto { get; set; }
        public string Author { get; set; }

        public string Description { get; set; }

        public Sach() { }
        public Sach(int _ID, string _Name, float _Price, string _CoverPhoto, string _Author, string _Description)
        {
            ID = _ID;
            Name = _Name;
            Price = _Price;
            CoverPhoto = _CoverPhoto;
            Author = _Author;
            Description = _Description;
        }
    }
}