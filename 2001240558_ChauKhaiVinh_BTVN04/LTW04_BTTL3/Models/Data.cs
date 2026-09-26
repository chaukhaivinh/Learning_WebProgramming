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

        public Data()
        {
            Categories = new List<Category>
            {
                new Category(1, "Nước uống"),
                new Category(2, "Ăn vặt"),
                new Category(3, "Giải trí")
            };
            Products = new List<Product>
            {
                new Product("Trà sữa trân châu", 25000, 1),
                new Product("Bánh tráng trộn", 20000, 2),
                new Product("Tô tượng", 35000, 3),
                new Product("Hồng trà tắc", 18000, 1),
                new Product("Xoài lắc", 22000, 2)
            };
        }
    }
}