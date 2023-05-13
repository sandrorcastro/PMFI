using Domain.Entities;
using Domain.Interfaces.Base;

namespace Domain.Interfaces.Services
{
    public interface IEstadoService : IServiceBase<Estado>
    {
            Estado BuscarPorDescricao(string descricao);
            Estado BuscarPorSigla(string sigla);
    }
}
