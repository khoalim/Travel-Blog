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
        IRepository<Category> categoryRepo;

        public PostController(IRepository<Post> postRepo, IRepository<Category> categoryRepo)
        {
            this.postRepo = postRepo;
            this.categoryRepo = categoryRepo;
        }

        public ViewResult AllPostsByCategory()
        {
            var model = categoryRepo.GetAll();
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
            post.PublishDate = DateTime.Now;
            postRepo.Create(post);
            return RedirectToAction("PostByCategory", new { id = post.CategoryID });
        }
            
        [HttpGet]
        public ViewResult CreateByCategoryID(int id)
        {
            ViewBag.CategoryID = id;
            return View();
        }

        [HttpGet]
        public ViewResult CreatePostFromIndex()
        {            
            return View();
        }

        [HttpGet]
        public ViewResult EditByCategoryID(int id)
        {
            var model = postRepo.GetByID(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult EditByCategoryID(Post post)
        {
            post.PublishDate = DateTime.Now;
            postRepo.Edit(post);
            return RedirectToAction("PostByCategory", new { id = post.CategoryID });
        }


    }
}