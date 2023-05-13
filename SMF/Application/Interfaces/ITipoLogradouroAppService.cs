
using Application.Interfaces.Base;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface ITipoLogradouroAppService : IAppServiceBase<TipoLogradouro>
    {
        IEnumerable<TipoLogradouro> BuscarPorDescricao(string descricao);
    }
}
