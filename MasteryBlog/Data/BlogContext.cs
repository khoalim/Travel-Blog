using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MasteryBlog.Models.Destination;
using MasteryBlog.Models.Post;
using Microsoft.EntityFrameworkCore;

namespace MasteryBlog.Data
{
    public class BlogContext : DbContext
    {

        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=BlogTesting;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Destination>().HasData(
                new Destination()
                {
                    Id = 1,
                    Image = "/Images/FamilyVacation.jpg",
                    Name = "Family Getaway",
                    Description = "Great for family fun",
                },

                new Destination()
                {
                    Id = 2,
                    Image = "/Images/BusinessTrip.jpg",
                    Name = "Business Trip",
                    Description = "Work hard, play hard",
                },

                new Destination()
                {
                    Id = 3,
                    Image = "Images/Retirement.jpg",
                    Name = "Retirement",
                    Description = "Top of the buckeklist",
                },

                new Destination()
                {
                    Id = 4,
                    Image = "Images/Honeymoon.jpg",
                    Name = "Honeymoon",
                    Description = "Paradise",
                }
                );

            //modelBuilder.Entity<Post>().HasData(
            //    new Post()
            //    {
            //        ID = 1,
            //        Title = "Travelling with picky eaters",
            //        Body = "Clean excursion wanderlust design wanderlust WordPress blogger, organized theme website organized excursion cute. Darn colorful colorful whimsical, WordPress whimsical colorful modern design webdesign clean adventure excursion.",
            //        Author = "Jane Doe",
            //        Category = "Family Getaway",
            //        DestinationID = 1,
            //    }
            //    );


        }
    }
}