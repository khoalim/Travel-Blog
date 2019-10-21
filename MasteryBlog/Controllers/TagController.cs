using MasteryBlog.Models;
using MasteryBlog.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasteryBlog.Controllers
{
    public class TagController: Controller
    {
        IRepository<Tag> tagRepo;

        public TagController(IRepository<Tag> tagRepo)
        {
            this.tagRepo = tagRepo;
            
        }

        public ViewResult Index()
        {
            var model = tagRepo.GetAll();
            return View(model);        
        }

        public ViewResult Details(int id)
        {
            var model = tagRepo.GetByID(id);
            return View(model);
        }
    }
}
