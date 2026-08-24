using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LTW02_BaiMau.Models
{
    public class PhongBanViewModel
    {
        public List<PhongBan> DS_PhongBan { get; set; }
        public PhongBanViewModel()
        {
            DS_PhongBan = new List<PhongBan>
            {
                new PhongBan
                {
                    ID= 1,
                    Name="Phòng kế toán"
                },
                new PhongBan
                {
                    ID = 2,
                    Name="Phòng nhân sự"
                }
            };
        }
    }
}