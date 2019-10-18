using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasteryBlog.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }
        //public string Tags { get; set; }

        public virtual int CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public virtual IList<PostTag> PostTags { get; set; }

        public Post()
        {

        }

        public Post(int id, string title, string body, string author, DateTime publishDate /*string tags*/)
        {
            this.ID = id;
            this.Title = title;
            this.Body = body;
            this.Author = author;
            this.PublishDate = publishDate;            
            //this.Tags = tags;
        }
    }
}
