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
        IRepository<Tag> tagRepo;

        public PostController(IRepository<Post> postRepo, IRepository<Category> categoryRepo, IRepository<Tag> tagRepo)
        {
            this.postRepo = postRepo;
            this.categoryRepo = categoryRepo;
            this.tagRepo = tagRepo;
        }

        public ViewResult PostsIndex()
        {
            var model = categoryRepo.GetAll();
            return View(model);
        }

        public ViewResult PostByCategory(int id)
        {
            var model = postRepo.GetByCategoryID(id);
            return View(model);
        }

        public ViewResult PostByTagID(int id)
        {
            var model = postRepo.GetByTagID(id);
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

        [HttpGet]
        public ViewResult DeleteByCategoryID(int id)
        {
            var model = postRepo.GetByID(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(Post post)
        {
            postRepo.Delete(post);
            return RedirectToAction("PostByCategory", new { id = post.CategoryID });
        }



    }
}