using Domain.Entities;
using Domain.Interfaces.Base;

namespace Domain.Interfaces.Services
{
    public interface ITipoLogradouroService : IServiceBase<TipoLogradouro>
    {
        IEnumerable<TipoLogradouro> BuscarPorDescricao(string nome);
    }
}
