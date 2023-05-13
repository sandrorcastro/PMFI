
using Application.Interfaces.Base;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IEnderecoAppService : IAppServiceBase<Endereco>
    {
        IEnumerable<Endereco> BuscarPorDescricao(string descricao);
    }
}
