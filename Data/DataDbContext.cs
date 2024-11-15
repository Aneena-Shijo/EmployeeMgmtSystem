using EmployeeMgmtSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeMgmtSystem.Data
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
