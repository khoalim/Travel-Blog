using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasteryBlog.Models
{
    public class Category
    {
        public int Id {get; set;}
        public string Image { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Post> Posts { get; set; }

        public Category()
        {
        }

       
    }

}
