using MasteryBlog.Data;
using MasteryBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasteryBlog.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        private BlogContext db;

        public CategoryRepository()
        {
        }

        public CategoryRepository(BlogContext db)
        {
            this.db = db;
        }

        public int Count()
        {
            return db.Categories.Count();
        }

        public void Create(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
        }

        public void Edit(Category category)
        {
            db.Categories.Update(category);
            db.SaveChanges();
        }

        public void Delete(Category category)
        {
            db.Categories.Remove(category);
            db.SaveChanges();
        }

        public IEnumerable<Category> GetAll()
        {
            return db.Categories.ToList();
        }

        public IEnumerable<Category> GetByCategoryID(int id)
        {
            throw new NotImplementedException();
        }

        public Category GetByID(int id)
        {
            return db.Categories.Single(d => d.Id == id);
        }

        public void Save()
        {
            db.SaveChanges();
        }
        //public List<Category> categoriesList;
        //public CategoryRepository()
        //{
        //    categoriesList = new List<Category>()
        //    {
        //        new Category(1, "/Images/FamilyVacation.jpg", "Family Getaway", "Great for family fun"),
        //        new Category(2, "/Images/BusinessTrip.jpg", "Business Trip", "Work hard, Play hard"),
        //        new Category(3, "/Images/Retirement.jpg", "Retirement", "Top of the bucket-list"),
        //        new Category(4, "/Images/Honeymoon.jpg", "Honeymoon", "Paradise")
        //    };
        //}
    }
}
