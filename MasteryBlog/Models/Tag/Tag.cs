using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasteryBlog.Models
{
    public class Tag
    {
        public int TagID { get; set; }
        public string Name { get; set; }

        public virtual IList<PostTag> PostTags { get; set; }

        public Tag()
        {

        }   
    }
}

