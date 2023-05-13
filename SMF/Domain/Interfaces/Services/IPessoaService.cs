using Domain.Entities;
using Domain.Interfaces.Base;

namespace Domain.Interfaces.Services
{
    public interface IPessoaService : IServiceBase<Pessoa>
    {
        IEnumerable<Pessoa> BuscarPorNome(string nome);
    }
}
