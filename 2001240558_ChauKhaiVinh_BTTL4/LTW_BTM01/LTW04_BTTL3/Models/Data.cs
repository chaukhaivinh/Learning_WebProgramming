using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LTW04_BTTL3.Models
{
    public class Data
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }

        // Constructor tự động tạo sẵn dữ liệu khi class Data được gọi
        public Data()
        {
            Categories = new List<Category>
            {
                new Category { CategoryId = 1, CategoryName = "Nước uống" },
                new Category { CategoryId = 2, CategoryName = "Ăn vặt" },
                new Category { CategoryId = 3, CategoryName = "Giải trí" }
            };

            Products = new List<Product>
            {
                new Product{ProductName="Cà phê đen",Price=40000,CategoryId=1},
                new Product{ProductName="Cà sữa",Price=50000,CategoryId=2},
                new Product{ProductName="Matcha Latte",Price=75000,CategoryId=3},
                new Product{ProductName="Hồng trà sữa chuối",Price=55000,CategoryId=4},
            };
        }
    }
}