using Domain.Entities;
using Domain.Interfaces.Base;

namespace Domain.Interfaces.Services
{
    public interface IEnderecoService : IServiceBase<Endereco>
    {
        IEnumerable<Endereco> BuscarPorDescricao(string descricao);
    }
}
