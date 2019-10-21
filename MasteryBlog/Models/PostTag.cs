using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasteryBlog.Models
{
    public class PostTag
    {
        public int PostID { get; set; }
        public virtual Post Post { get; set; }


        public int TagID { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
