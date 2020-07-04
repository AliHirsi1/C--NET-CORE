using EmployeeManagement.Modal.Modals;
using Microsoft.EntityFrameworkCore;


namespace EmployeeManagement.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employee { get; set; }
    }
}
