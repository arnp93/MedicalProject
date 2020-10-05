using Fardin.DataLayer.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fardin.DataLayer.Context
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<AdminPanel> admins { get; set; }
        public DbSet<Post> posts { get; set; }
        public DbSet<SubPost> subPosts { get; set; }
        public DbSet<SubPostDescription> subPostDescriptions { get; set; }
        public DbSet<Comment> comments  { get; set; }
        public DbSet<ContactUs> contacts { get; set; }
        public DbSet<ImageGallery> imageGalleries { get; set; }
        public DbSet<SiteStatic> siteStatics { get; set; }
        public DbSet<SocialNetwork> socialNetworks { get; set; }
        public DbSet<About> Abouts { get; set; }
    }
}
