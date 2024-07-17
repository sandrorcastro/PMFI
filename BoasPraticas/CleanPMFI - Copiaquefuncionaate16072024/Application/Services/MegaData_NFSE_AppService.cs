using Application.Interfaces;
using Application.Services.Base;
using Domain.Entities;
using Domain.Entities.MegaData;
using Domain.Interfaces.Base;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class MegaData_NFSE_AppService : AppServiceBase<MegaData_NFSE>, IMegaData_NFSE_AppService
    {
        private readonly IMegaData_NFSE_Service ufService;

        public MegaData_NFSE_AppService(IMegaData_NFSE_Service _ufService)
            : base(_ufService)
        {
            ufService = _ufService;
        }
    }
}
