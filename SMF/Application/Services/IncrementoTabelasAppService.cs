using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;
using Domain.Services;

namespace Application.Services
{
    public class IncrementoTabelasAppService : AppServiceBase<IncrementoTabelas>, IIncrementoTabelasAppService
    {
        private readonly IIncrementoTabelasService _incrementoTabelasService;

        public IncrementoTabelasAppService(IIncrementoTabelasService incrementoTabelasService)
            : base(incrementoTabelasService)
        {
            _incrementoTabelasService = incrementoTabelasService;
        }
        public IncrementoTabelas BuscarPorTabela(string tabela)
        {
            return _incrementoTabelasService.BuscarPorTabela(tabela);
        }

        public long Incrementar(string? tabela, string? parametro, string? ano)
        {
            return _incrementoTabelasService.Incrementar(tabela,parametro,ano);
        }

        public long ValorAtual(string? tabela, string? parametro, string? ano)
        {
            return _incrementoTabelasService.ValorAtual(tabela, parametro, ano);
        }
    }
}
