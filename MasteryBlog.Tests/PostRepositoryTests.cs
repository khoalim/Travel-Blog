using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Linq;
using MasteryBlog.Repositories;
using MasteryBlog.Data;
using MasteryBlog.Models;

namespace MasteryBlog.Tests
{
    public class PostRepositoryTests : IDisposable
    {
        private BlogContext db;
        private PostRepository underTest;

        public PostRepositoryTests()
        {
            db = new BlogContext();
            db.Database.BeginTransaction();

            underTest = new PostRepository(db);
        }
        public void Dispose()
        {
            db.Database.RollbackTransaction();
        }

        [Fact]
        public void Count_Starts_At_Zero()
        {
            var count = underTest.Count();
            Assert.Equal(0, count);
        }

        [Fact]
        public void Create_Increases_Count()
        {
            underTest.Create(new Post() { Title = "Foo" });

            var count = underTest.Count();
            Assert.Equal(1, count);
        }

        [Fact]
        public void GetByID_Returns_Created_Item()
        {
            var expectedPost = new Post() { Title = "Dream Vacation" };
            underTest.Create(expectedPost);

            var result = underTest.GetByID(expectedPost.ID);

            Assert.Equal(expectedPost.Title, result.Title);
        }

        [Fact]

        public void Delete_Reduces_Count()
        {
            var post = new Post() { Title = "Dream Vacation" };
            underTest.Create(post);

            underTest.Delete(post);
            var count = underTest.Count();
            Assert.Equal(0, count);
        }

        [Fact]

        public void GetAll_Returns_All()
        {
            underTest.Create(new Post() { Title = "Dream Vacation" });
            underTest.Create(new Post() { Title = "Best Vacation" });

            var all = underTest.GetAll();
            Assert.Equal(2, all.Count());

        
        }

        
        
    }
}
