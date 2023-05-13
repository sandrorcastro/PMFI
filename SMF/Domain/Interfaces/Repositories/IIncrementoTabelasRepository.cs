using Domain.Entities;
using Domain.Interfaces.Base;

namespace Domain.Interfaces.Repositories
{
    public interface IIncrementoTabelasRepository : IRepositoryBase<IncrementoTabelas>
    {
        IncrementoTabelas BuscarPorTabela(string tabela);
        long ValorAtual(string? tabela, string? parametro, string? ano);
        long Incrementar(string tabela, string parametro, string ano);

    }
}
