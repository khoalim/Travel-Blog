using System;
using System.Linq;
using Xunit;
using MasteryBlog.Controllers;
using Microsoft.AspNetCore.Mvc;
using MasteryBlog.Repositories;
using MasteryBlog.Models;

namespace MasteryBlog.Tests
{
    public class DestinationControllerTests
    {
        IRepository<Destination> destinationRepo;

        public DestinationControllerTests()
        {
            destinationRepo = new DestinationRepository();
        }

        [Fact]
        public void Index_Returns_A_View()
        {
            var underTest = new DestinationController(destinationRepo);

            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }
    }
}
