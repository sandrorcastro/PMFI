
using Application.Interfaces.Base;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface ICidadeAppService : IAppServiceBase<Cidade>
    {
        IEnumerable<Cidade> BuscarPorDescricao(string nome);
    }
}
