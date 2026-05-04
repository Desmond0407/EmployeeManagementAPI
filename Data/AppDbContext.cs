using EmployeeManagementAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;


namespace EmployeeManagementAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
