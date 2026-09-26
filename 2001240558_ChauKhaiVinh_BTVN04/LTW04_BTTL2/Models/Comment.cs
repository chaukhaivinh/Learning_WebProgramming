using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LTW04_BTTL2.Models
{
    public class Comment
    {
        public string _UserName { get; set; }
        public string _Avatar {  get; set; }
        public DateTime _DateComment { get; set; }
        public string _CommentContent { get; set; }
        public int _StarRating { get; set; }


    }
}