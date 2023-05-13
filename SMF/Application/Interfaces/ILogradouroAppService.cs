
using Application.Interfaces.Base;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface ILogradouroAppService : IAppServiceBase<Logradouro>
    {
        IEnumerable<Logradouro> BuscarPorDescricao(string descricao);
    }
}
