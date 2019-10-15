using MasteryBlog.Data;
using MasteryBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasteryBlog.Repositories
{
    public class DestinationRepository : IRepository<Destination>
    {
        private BlogContext db;

        public DestinationRepository()
        {
        }

        public DestinationRepository(BlogContext db)
        {
            this.db = db;
        }

        public int Count()
        {
            return db.Destinations.Count();
        }

        public void Create(Destination destination)
        {
            db.Destinations.Add(destination);
            db.SaveChanges();
        }

        public IEnumerable<Destination> GetAll()
        {
            return db.Destinations.ToList();
        }

        public IEnumerable<Destination> GetByDestinationID(int id)
        {
            throw new NotImplementedException();
        }

        public Destination GetByID(int id)
        {
            return db.Destinations.Single(d => d.Id == id);
        }

        public void Save()
        {
            db.SaveChanges();
        }
        //public List<Destination> destinationsList;
        //public DestinationRepository()
        //{
        //    destinationsList = new List<Destination>()
        //    {
        //        new Destination(1, "/Images/FamilyVacation.jpg", "Family Getaway", "Great for family fun"),
        //        new Destination(2, "/Images/BusinessTrip.jpg", "Business Trip", "Work hard, Play hard"),
        //        new Destination(3, "/Images/Retirement.jpg", "Retirement", "Top of the bucket-list"),
        //        new Destination(4, "/Images/Honeymoon.jpg", "Honeymoon", "Paradise")
        //    };
        //}
    }
}
