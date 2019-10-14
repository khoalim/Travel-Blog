using System;
using System.Linq;
using Xunit;
using MasteryBlog.Controllers;
using Microsoft.AspNetCore.Mvc;
using MasteryBlog.Repositories;
using MasteryBlog.Models.Destination;

namespace MasteryBlog.Tests
{
    public class DestinationControllerTests
    {
        IRepository<Destination> destinationRepo;

        [Fact]
        public void Index_Returns_A_View()
        {
            var underTest = new DestinationController(destinationRepo);

            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }
    }
}
