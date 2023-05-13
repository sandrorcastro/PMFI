using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class TipoLogradouroAppService : AppServiceBase<TipoLogradouro>, ITipoLogradouroAppService
    {
        private readonly ITipoLogradouroService _tipoLogradouroService;

        public TipoLogradouroAppService(ITipoLogradouroService tipoLogradouroService)
            : base(tipoLogradouroService)
        {
            _tipoLogradouroService = tipoLogradouroService;
        }

        public IEnumerable<TipoLogradouro> BuscarPorDescricao(string nome)
        {
            return _tipoLogradouroService.BuscarPorDescricao(nome);
        }
    }
}
