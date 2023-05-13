using Domain.Entities;
using Domain.Interfaces.Base;

namespace Domain.Interfaces.Services
{
    public interface ITipoPessoaService : IServiceBase<TipoPessoa>
    {
        IEnumerable<TipoPessoa> BuscarPorDescricao(string descricao);
    }
}
