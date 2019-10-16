using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MasteryBlog.Data;
using MasteryBlog.Models;

namespace MasteryBlog.Repositories
{
    public class PostRepository : IRepository<Post>
    {
        private BlogContext db;

        public PostRepository(BlogContext db)
        {
            this.db = db;
        }
        
        public int Count()
        {
            return db.Posts.Count();
        }

        public void Create(Post post)
        {
            db.Posts.Add(post);
            db.SaveChanges();
        }

        public Post GetByID(int id)
        {
            return db.Posts.Single(p => p.ID == id);
        }

        public IEnumerable<Post> GetAll()
        {
            return db.Posts.ToList();
        }

        public IEnumerable<Post> GetByCategoryID(int categoryID)
        {
            var posts = db.Posts.Where(p => p.CategoryID == categoryID);
            return posts;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Delete(Post post)
        {
            db.Posts.Remove(post);
            db.SaveChanges();
        }

        public void Edit(Post post)
        {
            db.Posts.Update(post);
            db.SaveChanges();

        }
    }
}
