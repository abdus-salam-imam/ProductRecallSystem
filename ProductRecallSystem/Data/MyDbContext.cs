using Microsoft.EntityFrameworkCore;
using ProductRecallSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductRecallSystem.Data
{
    public class MyDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-P4RM1BO;Database=ProductRecall;Trusted_Connection=True;");
        }


        //DbSet

        public DbSet<Product> Products { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Recall> Recalls { get; set; }
        public DbSet<Announcement> Announcements { get; set; }



    }
}
