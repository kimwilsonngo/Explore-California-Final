using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExploreCalifornia.Models
{

    public class PhotoDataContext : DbContext
    {
        //I split up the photo class because the view design requires a reference to ExploreCalifornia.Models.Photo
        public DbSet<Photo> Photos { get; set; }
        public PhotoDataContext(DbContextOptions<PhotoDataContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }

    
}
