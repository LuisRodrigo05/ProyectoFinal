using ProyectoFinal.Modelo;

namespace ProyectoFinal.Repositorio
{
    public interface IRepositorioTerapeutas
    {
        Task<List<Terapeuta>> GetAll();
        Task<Terapeuta?> Get(int id);
        Task<Terapeuta> Add(Terapeuta terapeuta);
        Task Update(int id, Terapeuta terapeuta);
        Task Delete(int id);
    }
}
