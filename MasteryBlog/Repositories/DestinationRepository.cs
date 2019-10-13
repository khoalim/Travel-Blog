using MasteryBlog.Models.Destination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasteryBlog.Repositories
{
    public class DestinationRepository : IRepository<Destination>
    {

        public List<Destination> destinationsList;
        public DestinationRepository()
        {
            destinationsList = new List<Destination>()
            {
                new Destination(1, "/Images/FamilyVacation.jpg", "Family Getaway", "Great for family fun"),
                new Destination(2, "/Images/BusinessTrip.jpg", "Business Trip", "Work hard, Play hard"),
                new Destination(3, "/Images/Retirement.jpg", "Retirement", "Top of the bucket-list"),
                new Destination(4, "/Images/Honeymoon.jpg", "Honeymoon", "Paradise")
            };
        }

        public IEnumerable<Destination> GetAll()
        {
            return destinationsList;
        }

        public Destination GetByID(int id)
        {
            return destinationsList.Single(d => d.Id == id);
        }
    }
}
