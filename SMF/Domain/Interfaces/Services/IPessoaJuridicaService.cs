using Domain.Entities;
using Domain.Interfaces.Base;

namespace Domain.Interfaces.Services
{
    public interface IPessoaJuridicaService : IServiceBase<PessoaJuridica>
    {
        IEnumerable<PessoaJuridica> BuscarPorNome(string nome);
    }
}
