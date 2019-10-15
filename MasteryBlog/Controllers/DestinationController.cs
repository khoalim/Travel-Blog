using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MasteryBlog.Models;
using MasteryBlog.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MasteryBlog.Controllers
{
    public class DestinationController  : Controller
    {
        IRepository<Destination> destinationRepo;

        public DestinationController(IRepository<Destination> destinationRepo)
        {
            this.destinationRepo = destinationRepo;
        }

        public ViewResult Index()
        {
            var model = destinationRepo.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = destinationRepo.GetByID(id);
            return View(model);
        }
    }
}
