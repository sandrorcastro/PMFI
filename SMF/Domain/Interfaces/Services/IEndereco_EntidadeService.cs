using Domain.Entities;
using Domain.Interfaces.Base;

namespace Domain.Interfaces.Services
{
    public interface IEndereco_EntidadeService : IServiceBase<Endereco_Entidade>
    {
        IEnumerable<Endereco_Entidade> BuscarPorDescricao(string descricao);
    }
}
