using Domain.Entities;
using Domain.Interfaces.Base;

namespace Domain.Interfaces.Repositories
{
    public interface ITipoPessoaRepository : IRepositoryBase<TipoPessoa>
    {
        IEnumerable<TipoPessoa> BuscarPorDescricao(string descricao);
    }
}
