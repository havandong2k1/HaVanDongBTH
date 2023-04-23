using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using baithuchanh1004.Models;

namespace MvcMovie.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<baithuchanh1004.Models.Student> Student { get; set; } = default!;

        public DbSet<baithuchanh1004.Models.Customer> Customer { get; set; } = default!;

        public DbSet<baithuchanh1004.Models.Employee> Employee { get; set; } = default!;
        public DbSet<baithuchanh1004.Models.Faculty> Faculty { get; set; } = default!;
       
    }
}
