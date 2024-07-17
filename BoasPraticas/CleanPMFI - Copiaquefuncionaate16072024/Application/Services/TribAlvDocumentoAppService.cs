using Application.Interfaces;
using Application.Services.Base;
using Domain.Entities;
using Domain.Interfaces.Base;
using Domain.Interfaces.Services;
using Domain.Services;

namespace Application.Services
{
    public class TribAlvDocumentoAppService : AppServiceBase<TribAlvDocumento>, ITribAlvDocumentoAppService
    {
        private readonly ITribAlvDocumentoService tribAlvDocumentoService;

        public TribAlvDocumentoAppService(ITribAlvDocumentoService _tribAlvDocumentoService)
            : base(_tribAlvDocumentoService)
        {
            tribAlvDocumentoService = _tribAlvDocumentoService;
        }
    }
}
