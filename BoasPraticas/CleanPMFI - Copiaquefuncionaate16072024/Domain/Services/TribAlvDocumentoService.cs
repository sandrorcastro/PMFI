using Domain.Entities;
using Domain.Interfaces.Base;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Services.Base;

namespace Domain.Services
{
    public class TribAlvDocumentoService : ServiceBase<TribAlvDocumento>, ITribAlvDocumentoService
    {
        private readonly ITribAlvDocumentoRepository _Repository;

        public TribAlvDocumentoService(ITribAlvDocumentoRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }
    }
}
