using Domain.Entities;
using Domain.Interfaces.Base;

namespace Domain.Interfaces.Services
{
    public interface IPaisService : IServiceBase<Pais>
    {
        IEnumerable<Pais> BuscarPorDescricao(string nome);
    }
}
