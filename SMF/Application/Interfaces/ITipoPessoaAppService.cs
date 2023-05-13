
using Application.Interfaces.Base;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface ITipoPessoaAppService : IAppServiceBase<TipoPessoa>
    {
        IEnumerable<TipoPessoa> BuscarPorDescricao(string descricao);
    }
}
