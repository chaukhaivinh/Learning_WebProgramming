using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LTW02_Bai03.Models
{
    public class SachViewModel
    {
        public List<LoaiSach> _DS_Loai { get; set; }
        public List<Sach> _DS_Sach { get; set; }
        public SachViewModel()
        {
            _DS_Loai = new List<LoaiSach>();
            _DS_Loai.Add(new LoaiSach(1, "Sách giáo khoa"));
            _DS_Loai.Add(new LoaiSach(2, "Sách từ điển"));
            _DS_Loai.Add(new LoaiSach(3, "Truyện đại học"));
            _DS_Loai.Add(new LoaiSach(4, "Truyện tranh"));

            _DS_Sach = new List<Sach>
     {
         new Sach(1, "Toán 10 Nâng cao", 15000, "h1.png", 1),
         new Sach(2, "Ngữ Văn 11", 2100, "h2.png", 1),
         new Sach(3, "Từ điển 1000 từ", 56000, "h3.png", 2),
         new Sach(4, "Anh - Việt 500 từ", 47000, "h4.png", 2),
         new Sach(5, "Anh - Anh", 120900, "h5.png", 2),
         new Sach(6, "Cơ sở dữ liệu", 34000, "h11.png", 3),
         new Sach(7, "Doreamon", 45000, "h14.png", 4)
     };

        }
    }
}