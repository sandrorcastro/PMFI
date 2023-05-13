
using Application.Interfaces.Base;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IBairroAppService : IAppServiceBase<Bairro>
    {
        IEnumerable<Bairro> BuscarPorDescricao(string descricao);
    }
}
