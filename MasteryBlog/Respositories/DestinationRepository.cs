﻿using MasteryBlog.Models.Destination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasteryBlog.Respositories
{
    public class DestinationRepository : IRepository<Destination>
    {

        public List<Destination> destinationsList;
        public DestinationRepository()
        {
            destinationsList = new List<Destination>()
            {
                new Destination(1, "Image", "Family Getaway", "Great for family fun"),
                new Destination(2, "Image", "Business Trip", "Work hard, Play hard"),
                new Destination(3, "Image", "Retirement", "Top of the bucket-list"),
                new Destination(4, "Image", "Honeymoon", "Paradise")
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