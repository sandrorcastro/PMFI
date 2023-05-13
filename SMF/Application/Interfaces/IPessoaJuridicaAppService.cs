
using Application.Interfaces.Base;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IPessoaJuridicaAppService : IAppServiceBase<PessoaJuridica>
    {
        IEnumerable<PessoaJuridica> BuscarPorNome(string nome);
    }
}
