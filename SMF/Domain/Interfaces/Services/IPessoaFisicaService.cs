using Domain.Entities;
using Domain.Interfaces.Base;

namespace Domain.Interfaces.Services
{
    public interface IPessoaFisicaService : IServiceBase<PessoaFisica>
    {
        IEnumerable<PessoaFisica> BuscarPorNome(string nome);
    }
}
