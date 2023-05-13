using Domain.Entities;
using Domain.Interfaces.Base;

namespace Domain.Interfaces.Repositories
{
    public interface ILogradouroRepository : IRepositoryBase<Logradouro>
    {
        IEnumerable<Logradouro> BuscarPorDescricao(string descricao);
    }
}
