using Domain.Entities;
using Domain.Interfaces.Base;

namespace Domain.Interfaces.Repositories
{
    public interface IEndereco_EntidadeRepository : IRepositoryBase<Endereco_Entidade>
    {
        IEnumerable<Endereco_Entidade> BuscarPorDescricao(string descricao);
    }
}
