using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LTW04_BTTL2.Models;

namespace LTW04_BTTL2.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Detail()
        {
            var sp = new Product
            {
                _Name = "Jodan 1",
                _Decription="Giày thể thao thời trang",
                _Image= "https://sneakerholicvietnam.vn/wp-content/uploads/2025/08/air-jordan-1-low-sail-soft-pearl-ih7323-100-1.jpg",
                _Price=3500000,
                
            };
            var bl = new List<Comment>
            {
                new Comment{_UserName="Dương Gia Linh",
                            _Avatar="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQGh3KE98kk0UncUsELQnOmWHSUsnkYwcn8MN3ndYp7XQ&s=10",
                            _DateComment=new DateTime(2026,06,01), _CommentContent="Đẹp phù hợp với giới trẻ",_StarRating=5},
                new Comment{_UserName="Châu Khải Vinh",
                            _Avatar="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSBZkrGklLXzko0Bs1pu9L0BPGP_IWRB2GIfRJ1gSWvSA&s=10",
                            _DateComment=new DateTime(2026,02,04), _CommentContent="Sản phẩm thoải mái phù hợp",_StarRating=5},
                new Comment{_UserName="Ngô Thuận Văn",
                            _Avatar="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSqamgSaGviFsg11l5gBKJOPAu2JUsQdegQAvVUL6WMow&s=10",
                            _DateComment=new DateTime(2026,10,08), _CommentContent="Sản phẩm khá mắc",_StarRating=2},

            };
            var ph = new FeedBack
            {
                _TotalCount = 85,
                _Average=4.0,
                _StarCount=new int[] { 0, 4, 4, 9, 17, 51 },
                _Comments=bl,
            };
            var viewModel =new ProductDetailViewModel
            { 
                ProductInfo = sp,
                FeedBackInfo = ph,
            };

            return View(viewModel);
        }
    }
}