using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CentroSalud.DAL.Data
{
    public class DbCentroSaludContextFactory
        : IDesignTimeDbContextFactory<DbCentroSaludContext>
    {
        public DbCentroSaludContext CreateDbContext(string[] args)
        {
            var optionsBuilder =
                new DbContextOptionsBuilder<DbCentroSaludContext>();

            optionsBuilder.UseSqlServer(
                "Server=.;Database=CentroSaludDB;Trusted_Connection=True;TrustServerCertificate=True;");

            return new DbCentroSaludContext(optionsBuilder.Options);
        }
    }
}
