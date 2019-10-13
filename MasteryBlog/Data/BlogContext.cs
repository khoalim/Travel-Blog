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
    }
}