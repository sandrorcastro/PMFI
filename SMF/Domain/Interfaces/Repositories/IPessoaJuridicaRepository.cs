using Domain.Entities;
using Domain.Interfaces.Base;

namespace Domain.Interfaces.Repositories
{
    public interface IPessoaJuridicaRepository : IRepositoryBase<PessoaJuridica>
    {
        IEnumerable<PessoaJuridica> BuscarPorNome(string nome);
    }
}
