using Microsoft.EntityFrameworkCore;
using NutriVida.Models;

namespace NutriVida.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Plan> Planes { get; set; }
        public DbSet<Alimento> Alimentos { get; set; }
        public DbSet<Historial> Historiales { get; set; }
    }
}
