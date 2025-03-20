using EmployeeSearchApp.Models;
using Microsoft.EntityFrameworkCore;
using Peach_Clone.Data;
using Peach_Clone.Models;


namespace Peach_Clone.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }


    }
}
