using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class TextoAutuacaoAppService : AppServiceBase<TextoAutuacao>, ITextoAutuacaoAppService
    {
        private readonly ITextoAutuacaoService service;

        public TextoAutuacaoAppService(ITextoAutuacaoService _service)
            : base(_service)
        {
            service = _service;
        }

       
    }
}
