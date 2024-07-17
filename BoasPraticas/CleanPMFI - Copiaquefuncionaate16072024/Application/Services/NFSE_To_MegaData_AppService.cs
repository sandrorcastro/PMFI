using Application.Interfaces;
using Application.Services.Base;
using Domain.Entities;
using Domain.Entities.NFSEDB;
using Domain.Interfaces.Base;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class NFSE_To_MegaData_AppService : AppServiceBase<NfseTblNfse>, INFSE_To_MegaData_AppService
    {
        private readonly INfseTblNfse_Service nfsetblnfse_Service;

        public NFSE_To_MegaData_AppService(INfseTblNfse_Service _nfsetblnfse_Service)
            : base(_nfsetblnfse_Service)
        {
            nfsetblnfse_Service = _nfsetblnfse_Service;
        }
    }
}
