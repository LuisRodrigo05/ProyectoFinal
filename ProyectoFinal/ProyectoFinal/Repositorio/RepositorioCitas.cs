using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Modelo;

namespace ProyectoFinal.Repositorio
{
    public class RepositorioCitas : IRepositorioCitas
    {
        private readonly ConsultorioDBContext _context;


        public RepositorioCitas(ConsultorioDBContext context)
        {
            _context = context;
        }

        public async Task<Cita> Add(Cita cita)
        {
            await _context.Citas.AddAsync(cita);
            await _context.SaveChangesAsync();
            return cita;
        }

        public async Task Delete(int id)
        {
            var cita = await _context.Citas.FindAsync(id);
            if (cita != null)
            {
                _context.Citas.Remove(cita);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Cita?> Get(int id)
        {
            return await _context.Citas.FindAsync(id);
        }

        public async Task<List<Cita>> GetAll()
        {
            return await _context.Citas.ToListAsync();
        }

        public async Task<List<Terapeuta>> GetTerapeutas()
        {
            return await _context.Terapeutas.ToListAsync();
        }
        public async Task<List<Cliente>> GetPacientes()
        {
            return await _context.Pacientes.ToListAsync();
        }

        public async Task Update(int id, Cita cita)
        {
            var citaActual = await _context.Citas.FindAsync(id);
            if (citaActual != null)
            {
                citaActual.Fecha = cita.Fecha;
                citaActual.Hora = cita.Hora;
                await _context.SaveChangesAsync();
            }
        }
    }
}
