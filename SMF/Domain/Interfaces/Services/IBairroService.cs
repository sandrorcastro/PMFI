using Domain.Entities;
using Domain.Interfaces.Base;

namespace Domain.Interfaces.Services
{
    public interface IBairroService : IServiceBase<Bairro>
    {
        IEnumerable<Bairro> BuscarPorDescricao(string descricao);
    }
}
