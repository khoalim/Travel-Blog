using MasteryBlog.Data;
using MasteryBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasteryBlog.Repositories
{
    public class TagRepository
    {
        private BlogContext db;

        public TagRepository()
        {
        }

        public TagRepository(BlogContext db)
        {
            this.db = db;
        }

        public IEnumerable<Tag> GetAllTagNames()
        {
            return db.Tags.ToList();
        }

    }
}
