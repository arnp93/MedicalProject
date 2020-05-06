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
        public DbSet<PostDetail> postDetails { get; set; }
        public DbSet<DetailsDescription> detailsDescriptions { get; set; }
    }
}
