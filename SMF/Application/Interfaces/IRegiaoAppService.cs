
using Application.Interfaces.Base;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IRegiaoAppService : IAppServiceBase<Regiao>
    {
        IEnumerable<Regiao> BuscarPorDescricao(string descricao);
    }
}
