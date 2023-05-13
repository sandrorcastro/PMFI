using Domain.Entities;
using Domain.Interfaces.Base;

namespace Domain.Interfaces.Repositories
{
    public interface ICidadeRepository : IRepositoryBase<Cidade>
    {
        IEnumerable<Cidade> BuscarPorDescricao(string nome);
    }
}
