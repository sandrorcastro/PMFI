using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class CidadeAppService : AppServiceBase<Cidade>, ICidadeAppService
    {
        private readonly ICidadeService cidadeService;

        public CidadeAppService(ICidadeService _cidadeService)
            : base(_cidadeService)
        {
            cidadeService = _cidadeService;
        }

        public IEnumerable<Cidade> BuscarPorDescricao(string nome)
        {
            return cidadeService.BuscarPorDescricao(nome);
        }
    }
}
