
using Application.Interfaces.Base;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IPessoaAppService : IAppServiceBase<Pessoa>
    {
        IEnumerable<Pessoa> BuscarPorNome(string nome);
    }
}
