using Microsoft.EntityFrameworkCore;
using MvcInterserver.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace MvcInterserver.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 
        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Tag> Tags { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Blog>().HasData(
                new Blog { Id = 1, Name = "Tech Central", Description = "Based Blog"},
                new Blog { Id = 2, Name = "Book Frate", Description = "Book Blog" }

                );


        }


    }
}
