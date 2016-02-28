using Microsoft.Data.Entity;
using ScottBlog.Models;
using System.Collections.Generic;

namespace ScottModel.Models
{
    public class BloggingDbContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>()
                .Property(b => b.Url)
                .IsRequired();

        }
        
        
    }

}