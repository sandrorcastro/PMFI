using Domain.Entities;
using Domain.Entities.MegaData;
using Domain.Interfaces.Base;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Services.Base;

namespace Domain.Services
{
    public class MegaData_NFSE_Service : ServiceBase<MegaData_NFSE>, IMegaData_NFSE_Service
    {
        private readonly IMegaData_NFSE_Repository _Repository;

        public MegaData_NFSE_Service(IMegaData_NFSE_Repository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }
    }
}
