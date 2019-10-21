using MasteryBlog.Data;
using MasteryBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasteryBlog.Repositories
{
    public class TagRepository : IRepository<Tag>
    {
        private BlogContext db;
              

        public TagRepository(BlogContext db)
        {
            this.db = db;
        }

        public int Count()
        {
            return db.Tags.Count();
        }

        public void Create(Tag Tag)
        {
            db.Tags.Add(Tag);
            db.SaveChanges();
        }

        public void Edit (Tag tag)
        {
            db.Tags.Update(tag);
            db.SaveChanges();
        }

        public void Delete(Tag tag)
        {
            db.Tags.Remove(tag);
            db.SaveChanges();
        }

        public IEnumerable<Tag> GetAll()
        {
            return db.Tags.ToList();
        }
        

        public Tag GetByID(int id)
        {
            return db.Tags.SingleOrDefault(t => t.TagID == id);
        }

        public void Save()
        {
            db.SaveChanges();
        }               

        IEnumerable<Tag> IRepository<Tag>.GetByTagID(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tag> GetByCategoryID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
