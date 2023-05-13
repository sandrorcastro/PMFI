
using Application.Interfaces.Base;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IEstadoAppService : IAppServiceBase<Estado>
    {
        Estado BuscarPorDescricao(string estado);
        Estado BuscarPorSigla(string sigla);
    }
}
