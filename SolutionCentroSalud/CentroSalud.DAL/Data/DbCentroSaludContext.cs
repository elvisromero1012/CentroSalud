using Microsoft.EntityFrameworkCore;
using CentroSalud.Entity;

namespace CentroSalud.DAL.Data
{
    public class DbCentroSaludContext : DbContext
    {
        public DbCentroSaludContext(DbContextOptions<DbCentroSaludContext> options)
            : base(options)
        {
        }

        public DbSet<Especialidad> Especialidades { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
    }
}
