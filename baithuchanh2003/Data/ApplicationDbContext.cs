using Microsoft.EntityFrameworkCore;
using baithuchanh2003.Models;
using baithuchanh2003.Modles;

namespace baithuchanh2003.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students {get; set;} 
        public DbSet<Employee> Employees {get; set;}
         public DbSet<Customer> Customers {get; set;}
          public DbSet<Faculty> Faculty {get; set;}
    }
}