
using Application.Interfaces.Base;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IIncrementoTabelasAppService : IAppServiceBase<IncrementoTabelas>
    {
        IncrementoTabelas BuscarPorTabela(string tabela);
        long ValorAtual(string? tabela, string? parametro, string? ano);
        long Incrementar(string? tabela, string? parametro, string? ano);
    }
}
