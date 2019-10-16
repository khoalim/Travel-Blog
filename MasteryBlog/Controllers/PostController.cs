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

        public ViewResult PostByCategory(int id)
        {
            var model = postRepo.GetByCategoryID(id);
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
            return RedirectToAction("PostByCategory", new { id = post.CategoryID });
        }

        [HttpGet]
        public ViewResult CreateByDestinationID(int id)
        {
            ViewBag.DestinationID = id;
            return View();
        }
    }
}