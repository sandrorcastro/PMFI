using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class EstadoAppService : AppServiceBase<Estado>, IEstadoAppService
    {
        private readonly IEstadoService _estadoService;

        public EstadoAppService(IEstadoService estadoService)
            : base(estadoService)
        {
            _estadoService = estadoService;
        }

        public Estado BuscarPorDescricao(string descricao)
        {
            return _estadoService.BuscarPorDescricao(descricao);
        }
        public Estado BuscarPorSigla(string sigla)
        {
            return _estadoService.BuscarPorSigla(sigla);
        }
    }
}
