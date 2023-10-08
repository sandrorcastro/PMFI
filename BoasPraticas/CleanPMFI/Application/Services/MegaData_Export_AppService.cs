using Application.Interfaces;
using Application.Services.Base;
using Domain.Entities;
using Domain.Entities.MegaData;
using Domain.Entities.NFSEDB;
using Domain.Interfaces.Base;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class MegaData_Export_AppService : AppServiceBase<NfseTblNfse>, IMegaData_Export_AppService
    {
        private readonly INfseTblNfse_Service nfseTblNfseService;

        public MegaData_Export_AppService(INfseTblNfse_Service _nfseTblNfseService)
            : base(_nfseTblNfseService)
        {
            nfseTblNfseService = _nfseTblNfseService;
        }
    }
}
