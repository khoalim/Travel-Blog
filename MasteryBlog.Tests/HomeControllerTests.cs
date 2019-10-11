using MasteryBlog.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace MasteryBlog.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_Returns_A_View()
        {
            var underTest = new HomeController();

            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);

        }
    }
}
