using EmployeeMgmtSystem.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EmployeeMgmtSystem.Data
{


    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        
       

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }

}
