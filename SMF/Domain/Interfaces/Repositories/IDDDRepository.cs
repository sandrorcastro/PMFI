using Domain.Entities;
using Domain.Interfaces.Base;

namespace Domain.Interfaces.Repositories
{
    public interface IDDDRepository : IRepositoryBase<DDD>
    {
        IEnumerable<DDD> BuscarPorNumero(string numero);
    }
}
