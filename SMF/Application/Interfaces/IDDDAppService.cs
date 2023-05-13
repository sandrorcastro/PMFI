
using Application.Interfaces.Base;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IDDDAppService : IAppServiceBase<DDD>
    {
        IEnumerable<DDD> BuscarPorNumero(string numero);
    }
}
