using Domain.Entities;
using Domain.Interfaces.Base;

namespace Domain.Interfaces.Repositories
{
    public interface IRegiaoRepository : IRepositoryBase<Regiao>
    {
        IEnumerable<Regiao> BuscarPorDescricao(string descricao);
    }
}
