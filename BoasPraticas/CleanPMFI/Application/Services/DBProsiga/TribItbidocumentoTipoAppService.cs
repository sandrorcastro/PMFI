using Application.Interfaces.DBProsiga;
using Application.Services.Base;
using Application.ViewModels.DBProsiga;
using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Services.DBProsiga;
using Infrastructure.Repositories;

namespace Application.Services.DBProsiga
{
    public class TribItbidocumentoTipoAppService : AppServiceBase<TribItbidocumentoTipo>, ITribItbidocumentoTipoAppService
    {
        private readonly ITribItbidocumentoTipoService Service;

        public TribItbidocumentoTipoAppService(ITribItbidocumentoTipoService _Service)
            : base(_Service)
        {
            Service = _Service;
        }
        public IQueryable<TribItbidocumentoTipo> GetQueryableDocumentosExigidos(string praquem)
        {

            return Service.GetQueryableDocumentosExigidos(praquem);
        }
        public async Task<List<TribItbidocumentoTipo>> GetDocumentosExigidos(string praquem)
        {
            return await Service.GetDocumentosExigidos(praquem);
        }
        /*public TribItbidocumentoTipoAppService(IServiceBase<TribItbidocumentoTipo> _serviceBase) : base(_serviceBase)
        {
        }*/
    }
}
