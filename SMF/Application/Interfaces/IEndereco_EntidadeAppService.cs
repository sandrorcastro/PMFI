
using Application.Interfaces.Base;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IEndereco_EntidadeAppService : IAppServiceBase<Endereco_Entidade>
    {
        IEnumerable<Endereco_Entidade> BuscarPorDescricao(string descricao);
    }
}
