using Domain.Entities;
using Domain.Interfaces.Base;

namespace Domain.Interfaces.Repositories
{
    public interface IBairroRepository : IRepositoryBase<Bairro>
    {
        IEnumerable<Bairro> BuscarPorDescricao(string descricao);
    }
}
