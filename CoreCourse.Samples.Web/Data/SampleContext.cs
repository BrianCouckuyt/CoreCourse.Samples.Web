using CoreCourse.Samples.Web.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCourse.Samples.Web.Data
{
    public class SampleContext : DbContext
    {
        public SampleContext(DbContextOptions<SampleContext> options): base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { UserId = new Guid("5423D1BA-7CA2-4E08-8D6D-75929CAD659A"), UserName = "Joachim", Password = "1", IsAdmin = true },
                new User { UserId = new Guid("EBB81A0F-01E9-46D2-912C-51C770B122DF") , UserName = "Siegfried", Password = "1", IsAdmin = false }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
