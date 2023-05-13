using Domain.Entities;
using Domain.Interfaces.Base;

namespace Domain.Interfaces.Repositories
{
    public interface IEstadoRepository : IRepositoryBase<Estado>
    {
        Estado BuscarPorDescricao(string descricao);
        Estado BuscarPorSigla(string sigla);
    }
}
