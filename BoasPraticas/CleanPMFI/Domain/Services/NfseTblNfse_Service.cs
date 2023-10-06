using Domain.Entities;
using Domain.Entities.NFSEDB;
using Domain.Interfaces.Base;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Services.Base;

namespace Domain.Services
{
    public class NfseTblNfse_Service : ServiceBase<NfseTblNfse>, INfseTblNfse_Service
    {
        private readonly INfseTblNfse_Repository _Repository;

        public NfseTblNfse_Service(INfseTblNfse_Repository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }
    }
}
