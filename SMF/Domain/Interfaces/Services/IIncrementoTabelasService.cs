using Domain.Entities;
using Domain.Interfaces.Base;

namespace Domain.Interfaces.Services
{
    public interface IIncrementoTabelasService : IServiceBase<IncrementoTabelas>
    {
        IncrementoTabelas BuscarPorTabela(string tabela);
        long ValorAtual(string? tabela, string? parametro, string? ano);
        long Incrementar(string? tabela, string? parametro, string? ano);
    }
}
