using Microsoft.EntityFrameworkCore;

namespace ProyectoFinal.Modelo
{
    public class ConsultorioDBContext : DbContext
    {
        public ConsultorioDBContext(DbContextOptions<ConsultorioDBContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Pacientes { get; set; }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<Terapeuta> Terapeutas { get; set;}
    } 
}
