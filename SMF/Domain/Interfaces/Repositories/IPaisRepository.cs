using Domain.Entities;
using Domain.Interfaces.Base;

namespace Domain.Interfaces.Repositories
{
    public interface IPaisRepository : IRepositoryBase<Pais>
    {
        IEnumerable<Pais> BuscarPorDescricao(string nome);
    }
}
