using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ApplicationDemo {

    public class BloggingContext : DbContext
    {
       
        public DbSet<Post> Posts { get; set; }

        public string DbPath { get; }

        public BloggingContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "blogging.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }

   
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

       
    }

}