using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using baithuchanh1704.Models;

namespace MvcMovie.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<baithuchanh1704.Models.Sex> Sex { get; set; } = default!;

        public DbSet<baithuchanh1704.Models.Address> Address { get; set; } = default!;

        public DbSet<baithuchanh1704.Models.Student> Student { get; set; } = default!;

        public DbSet<baithuchanh1704.Models.Faculty> Faculty { get; set; } = default!;
    }
}
