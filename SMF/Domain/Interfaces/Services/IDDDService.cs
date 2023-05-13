using Domain.Entities;
using Domain.Interfaces.Base;

namespace Domain.Interfaces.Services
{
    public interface IDDDService : IServiceBase<DDD>
    {
        IEnumerable<DDD> BuscarPorNumero(string numero);
    }
}
