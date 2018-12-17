using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreCalifornia.Models
{
    public class Photo
    {
        public long Id { get; set; }

        public string title { get; set; }
        public string fileName { get; set; }
    }

    public class PhotoDataContext : DbContext
    {
        public DbSet<Photo> Photos { get; set; }
        public PhotoDataContext(DbContextOptions<PhotoDataContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }

    
}
