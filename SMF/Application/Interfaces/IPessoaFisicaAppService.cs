
using Application.Interfaces.Base;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IPessoaFisicaAppService : IAppServiceBase<PessoaFisica>
    {
        IEnumerable<PessoaFisica> BuscarPorNome(string nome);
    }
}
