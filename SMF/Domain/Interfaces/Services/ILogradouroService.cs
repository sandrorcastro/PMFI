using Domain.Entities;
using Domain.Interfaces.Base;

namespace Domain.Interfaces.Services
{
    public interface ILogradouroService : IServiceBase<Logradouro>
    {
        IEnumerable<Logradouro> BuscarPorDescricao(string descricao);
    }
}
