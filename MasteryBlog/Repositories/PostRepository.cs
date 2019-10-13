using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MasteryBlog.Data;
using MasteryBlog.Models.Post;

namespace MasteryBlog.Repositories
{
    public class PostRepository : IRepository<Post>
    {
        private BlogContext db;

        public PostRepository(BlogContext db)
        {
            this.db = db;
        }
        
        public IEnumerable<Post> GetAll()
        {
            return db.Posts;
        }

        //public IEnumerable<Post> GetByProductID(int postID)
        //{
        //    var posts = db.Posts.Where()
        //}

        public Post GetByID(int id)
        {
            return db.Posts.Single(p => p.ID == id);
        }
    }
}
