using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LTW02_Bai02.Models
{
    public class SachViewModel
    {
        public List<Sach> DS_Sach { get; set; }
        public SachViewModel() 
        {
            DS_Sach = new List<Sach>();
            DS_Sach.Add(new Sach(1, "Harry Potter và Hòn Đá Phù Thủy", 58800, "HonDaPhuThuy.png", "J. K. Rowling", "Tập 1"));
            DS_Sach.Add(new Sach(2, "Harry Potter và Phòng Chứa Bí Mật", 64200, "PhongChuaBiMat.png", "J. K. Rowling", "Tập 2"));
            DS_Sach.Add(new Sach(3, "Harry Potter và Tù Nhân Azkaban", 71250, "TuNhan1.png", "J. K. Rowling", "Tập 3"));
            DS_Sach.Add(new Sach(4, "Harry Potter và Chiếc Cốc Lửa", 49640, "ChieuCocLua.png", "J. K. Rowling", "Tập 4"));
            DS_Sach.Add(new Sach(5, "Harry Potter và Hội Phượng Hoàng", 65640, "HoiPhuongHoang.png", "J. K. Rowling", "Tập 5"));
            DS_Sach.Add(new Sach(6, "Harry Potter và Hoàng Tử Lai", 56640, "HoangTuLai.png", "J. K. Rowling", "Tập 6"));
            DS_Sach.Add(new Sach(7, "Harry Potter và Bảo Bối Tử Thần", 76640, "BaoBoiTuThan.png", "J. K. Rowling", "Tập 7"));
            DS_Sach.Add(new Sach(8, "Harry Potter và Đứa Trẻ Bị Nguyền Rủa", 80000, "DuaTre.png", "J. K. Rowling", "Tập 8"));
        }
    }
}