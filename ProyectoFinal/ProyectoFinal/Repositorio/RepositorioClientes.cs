using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Modelo;

namespace ProyectoFinal.Repositorio
{
    public class RepositorioClientes : IRepositorioClientes
    {
        private readonly ConsultorioDBContext _context;

        public RepositorioClientes(ConsultorioDBContext context)
        {
            _context = context;
        }

        public async Task<Cliente> Add(Cliente cliente)
        {
            await _context.Pacientes.AddAsync(cliente);
            await _context.SaveChangesAsync();
            return cliente;
        }

        public async Task Delete(int id)
        {
            var cliente = await _context.Pacientes.FindAsync(id);
            if (cliente != null)
            {
                _context.Pacientes.Remove(cliente);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Cliente?> Get(int id) 
        {
            return await _context.Pacientes.FindAsync(id);
        }

        public async Task<List<Cliente>> GetAll() 
        { 
            return await _context.Pacientes.ToListAsync();
        }

        public async Task Update(int id, Cliente cliente)
        {
            var pacienteActual = await _context.Pacientes.FindAsync(id);
            if(pacienteActual != null) 
            {
                pacienteActual.Nombre = cliente.Nombre;
                pacienteActual.Correo = cliente.Correo;
                pacienteActual.Telefono = cliente.Telefono;
                pacienteActual.Edad = cliente.Edad;
                pacienteActual.Direccion = cliente.Direccion;
                await _context.SaveChangesAsync();
            }
        }
    }
}
