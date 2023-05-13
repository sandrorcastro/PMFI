using Domain.Entities;
using Domain.Interfaces.Base;

namespace Domain.Interfaces.Repositories
{
    public interface ITipoLogradouroRepository : IRepositoryBase<TipoLogradouro>
    {
        IEnumerable<TipoLogradouro> BuscarPorDescricao(string nome);
    }
}
