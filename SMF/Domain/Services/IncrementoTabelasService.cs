using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class IncrementoTabelasService : ServiceBase<IncrementoTabelas>, IIncrementoTabelasService
    {
        private readonly IIncrementoTabelasRepository _Repository;

        public IncrementoTabelasService(IIncrementoTabelasRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }
        public IncrementoTabelas BuscarPorTabela(string tabela)
        {
            return _Repository.BuscarPorTabela(tabela);
        }

        public long Incrementar(string? tabela, string? parametro, string? ano)
        {
            return _Repository.Incrementar(tabela,parametro,ano);
        }

        public long ValorAtual(string? tabela, string? parametro, string? ano)
        {
            return _Repository.ValorAtual(tabela, parametro, ano);
        }
    }
}
