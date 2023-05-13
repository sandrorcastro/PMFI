using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class ProcessoAppService : AppServiceBase<Processo>, IProcessoAppService
    {
        private readonly IProcessoService service;

        public ProcessoAppService(IProcessoService _service)
            : base(_service)
        {
            service = _service;
        }

       
    }
}
