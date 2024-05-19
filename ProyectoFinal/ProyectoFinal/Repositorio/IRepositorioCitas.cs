using ProyectoFinal.Modelo;

namespace ProyectoFinal.Repositorio
{
    public interface IRepositorioCitas
    {
        Task<List<Cita>> GetAll();
        Task<Cita?> Get(int id);
        Task<List<Terapeuta>> GetTerapeutas();
        Task<List<Cliente>> GetPacientes();
        Task<Cita> Add(Cita cita);
        Task Update(int id, Cita cita);
        Task Delete(int id);
    }
}
