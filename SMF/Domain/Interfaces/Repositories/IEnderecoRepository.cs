using Domain.Entities;
using Domain.Interfaces.Base;

namespace Domain.Interfaces.Repositories
{
    public interface IEnderecoRepository : IRepositoryBase<Endereco>
    {
        IEnumerable<Endereco> BuscarPorDescricao(string descricao);
    }
}
