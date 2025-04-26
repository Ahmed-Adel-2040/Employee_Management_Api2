using Employee_Management_Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Employee_Management_Api.Persistence
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options) { }

        // Represents the Employees table in the database
        public DbSet<Employee> Employees => Set<Employee>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);   
        }
    }
}
