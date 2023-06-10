using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class ObjetoProcessoAppService : AppServiceBase<ObjetoProcesso>, IObjetoProcessoAppService
    {
        private readonly IObjetoProcessoService service;

        public ObjetoProcessoAppService(IObjetoProcessoService _service)
            : base(_service)
        {
            service = _service;
        }

       
    }
}
