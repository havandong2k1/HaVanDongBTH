using BaiThucHanh2703.Models;
using Microsoft.EntityFrameworkCore;

namespace BaiThucHanh2703.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Employee> Employees {get; set;}
        public DbSet<Customer> Customers {get; set;}
    }
}