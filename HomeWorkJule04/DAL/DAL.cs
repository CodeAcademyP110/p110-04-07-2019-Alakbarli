using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;
using HomeWorkJule04.Models;

namespace HomeWorkJule04.DAL
{
    public class MyDb:DbContext
    {
        public MyDb(DbContextOptions<MyDb>options):base(options)
        {

        }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<PopularDes> PopularDess { get; set; }
        public DbSet<HappyCostumer> HappyCostumers { get; set; }
        public DbSet<AboutMe> Abouts{ get; set; }
        public DbSet<Features> Features { get; set; }
        public DbSet<RecentBlog> RecentBlog { get; set; }
        public DbSet<RecentBlogContent> RecentBlogContents { get; set; }
    }
}
