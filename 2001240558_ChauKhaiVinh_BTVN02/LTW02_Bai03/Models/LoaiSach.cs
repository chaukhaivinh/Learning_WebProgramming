using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LTW02_Bai03.Models
{
    public class LoaiSach
    {
        public int IDType { get; set; }
        public string NameType { get; set; }
        public LoaiSach(int _IDType, string _NameType)
        {
            IDType = _IDType;
            NameType = _NameType;
        }
    }
}