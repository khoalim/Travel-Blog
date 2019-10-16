using System;
using System.Linq;
using Xunit;
using MasteryBlog.Controllers;
using Microsoft.AspNetCore.Mvc;
using MasteryBlog.Repositories;
using MasteryBlog.Models;

namespace MasteryBlog.Tests
{
    public class CategoryControllerTests
    {
        IRepository<Category> categoryRepo;

        public CategoryControllerTests()
        {
            categoryRepo = new CategoryRepository();
        }

        [Fact]
        public void Index_Returns_A_View()
        {
            var underTest = new CategoryController(categoryRepo);

            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }
    }
}
