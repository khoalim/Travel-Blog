using System;
using System.Linq;
using Xunit;
using MasteryBlog.Controllers;
using Microsoft.AspNetCore.Mvc;
using MasteryBlog.Repositories;
using MasteryBlog.Models;
using NSubstitute;
using System.Collections.Generic;

namespace MasteryBlog.Tests
{
    public class CategoryControllerTests
    {
        CategoryController underTest;
        IRepository<Category> categoryRepo;

        public CategoryControllerTests()
        {
            categoryRepo = Substitute.For<IRepository<Category>>();
            underTest = new CategoryController(categoryRepo);
        }

        [Fact]
        public void Index_Returns_A_View()
        {
            var underTest = new CategoryController(categoryRepo);

            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Passes_All_Categories_To_View()
        {
            var expectedCategories = new List<Category>();
            categoryRepo.GetAll().Returns(expectedCategories);

            var result = underTest.Index();

            Assert.Equal(expectedCategories, result.Model);
        }

        [Fact]
        public void Details_Returns_A_View()
        {
            var result = underTest.Details(1);

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Details_Passes_Course_To_View()
        {
            var expectedCategory = new Category();
            categoryRepo.GetByID(1).Returns(expectedCategory);

            var result = underTest.Details(1);

            Assert.Equal(expectedCategory, result.Model);
        }
    }
}
