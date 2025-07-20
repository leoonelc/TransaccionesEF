using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;

namespace TransaccionesEF.Data
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseMySql(
                "server=localhost;database=TransaccionesEF;user=root;password=;",
                new MySqlServerVersion(new Version(10, 4, 32))
            );

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
