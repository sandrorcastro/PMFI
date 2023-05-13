using Domain.Entities;
using Domain.Interfaces.Base;

namespace Domain.Interfaces.Repositories
{
    public interface IPessoaFisicaRepository : IRepositoryBase<PessoaFisica>
    {
        IEnumerable<PessoaFisica> BuscarPorNome(string nome);
    }
}
