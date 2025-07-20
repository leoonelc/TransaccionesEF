using Microsoft.EntityFrameworkCore;
using TransaccionesEF.Modelos;

namespace TransaccionesEF.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(
                    "server=localhost;database=TransaccionesEF;user=root;password=;",
                    new MySqlServerVersion(new Version(10, 4, 32)) // Versión de MariaDB
                );
            }
        }
    }
}
