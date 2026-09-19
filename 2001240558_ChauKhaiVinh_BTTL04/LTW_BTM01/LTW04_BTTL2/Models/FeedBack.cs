using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LTW04_BTTL2.Models
{
    public class FeedBack
    {
        public int _TotalCount {  get; set; }
        public double _Average { get; set; }
        public int[] _StarCount { get; set; }
        public List<Comment> _Comments { get; set; }
    }
}