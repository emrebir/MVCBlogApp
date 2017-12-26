using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCBlogApplication.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext():base("BlogDB")
        {
            Database.SetInitializer(new BlogInitializer());
        }
        public DbSet<Blog> Bloglar { get; set; }
        public DbSet<Category> Kategoriler { get; set; }
    }
}