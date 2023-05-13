using Domain.Entities;
using Domain.Interfaces.Base;

namespace Domain.Interfaces.Services
{
    public interface ICidadeService : IServiceBase<Cidade>
    {
        IEnumerable<Cidade> BuscarPorDescricao(string nome);
    }
}
