using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MasteryBlog.Repositories;
using MasteryBlog.Models;

namespace MasteryBlog.Controllers
{
    public class PostController : Controller
    {
        IRepository<Post> postRepo;

        public PostController(IRepository<Post> postRepo)
        {
            this.postRepo = postRepo;
        }

        public ViewResult Index()
        {
            var model = postRepo.GetAll();
            return View(model);
        }

        public ViewResult IndexByDestination(int id)
        {
            var model = postRepo.GetByDestinationID(id);
            return View(model);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Post post)
        {
            postRepo.Create(post);
            return RedirectToAction("IndexByDestination", new { id = post.DestinationID });
        }

        [HttpGet]
        public ViewResult CreateByDestinationID(int id)
        {
            ViewBag.DestinationID = id;
            return View();
        }
    }
}