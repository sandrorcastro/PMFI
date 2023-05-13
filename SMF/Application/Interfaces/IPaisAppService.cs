
using Application.Interfaces.Base;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IPaisAppService : IAppServiceBase<Pais>
    {
        IEnumerable<Pais> BuscarPorDescricao(string nome);
    }
}
