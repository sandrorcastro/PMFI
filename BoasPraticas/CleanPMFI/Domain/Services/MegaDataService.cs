using Domain.Entities;
using Domain.Entities.MegaData;
using Domain.Interfaces.Base;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Services.Base;

namespace Domain.Services
{
    public class MegaDataService : ServiceBase<MegaData_NFSE>, IMegaDataService
    {
        private readonly IMegaDataRepository _Repository;

        public MegaDataService(IMegaDataRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }
    }
}
