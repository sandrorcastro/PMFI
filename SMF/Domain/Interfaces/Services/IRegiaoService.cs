using Domain.Entities;
using Domain.Interfaces.Base;

namespace Domain.Interfaces.Services
{
    public interface IRegiaoService : IServiceBase<Regiao>
    {
        IEnumerable<Regiao> BuscarPorDescricao(string descricao);
    }
}
