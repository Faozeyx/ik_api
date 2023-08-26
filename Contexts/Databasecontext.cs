using IKAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace IKAPI.Contexts
{
    public class Databasecontext : DbContext
    {
        public Databasecontext(DbContextOptions options) : base(options) { }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Companies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOne(empl => empl.Company)
                .WithMany(comp => comp.Employees);
        }


    }
}
