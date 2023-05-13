using Domain.Entities;
using Domain.Interfaces.Base;

namespace Domain.Interfaces.Repositories
{
    public interface IPessoaRepository : IRepositoryBase<Pessoa>
    {
        IEnumerable<Pessoa> BuscarPorNome(string nome);
    }
}
