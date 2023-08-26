using IKAPI.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace IKAPI 
{ 
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<Databasecontext>
    {
        public Databasecontext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<Databasecontext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql("UserID=postgres;Password=12345;Host=localhost;Port=5432;Database=IK;");

            return new(dbContextOptionsBuilder.Options);
        }
    }
    
}
