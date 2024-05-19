using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Modelo;

namespace ProyectoFinal.Repositorio
{
    public class RepositorioTerapeutas : IRepositorioTerapeutas
    {
        private readonly ConsultorioDBContext _context;

        public RepositorioTerapeutas(ConsultorioDBContext context)
        {
            _context = context;
        }

        public async Task<Terapeuta> Add(Terapeuta terapeuta)
        {
            await _context.Terapeutas.AddAsync(terapeuta);
            await _context.SaveChangesAsync();
            return terapeuta;
        }

        public async Task Delete(int id)
        {
            var terapeuta = await _context.Terapeutas.FindAsync(id);
            if (terapeuta != null)
            {
                _context.Terapeutas.Remove(terapeuta);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Terapeuta?> Get(int id)
        {
            return await _context.Terapeutas.FindAsync(id);
        }

        public async Task<List<Terapeuta>> GetAll()
        {
            return await _context.Terapeutas.ToListAsync();
        }

        public async Task Update(int id, Terapeuta terapeuta)
        {
            var terapeutaActual = await _context.Terapeutas.FindAsync(id);
            if (terapeutaActual != null)
            {
                terapeutaActual.Nombre = terapeuta.Nombre;
                terapeutaActual.Correo = terapeuta.Correo;
                terapeutaActual.Telefono = terapeuta.Telefono;
                terapeutaActual.Especialidad = terapeuta.Especialidad;
                await _context.SaveChangesAsync();
            }
        }
    }
}
