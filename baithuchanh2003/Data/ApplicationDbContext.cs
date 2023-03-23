using Microsoft.EntityFrameworkCore;
using baithuchanh2003.Models;

namespace baithuchanh2003.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students {get; set;} 
    }
}