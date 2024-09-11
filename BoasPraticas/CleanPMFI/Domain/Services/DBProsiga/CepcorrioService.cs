using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Repositories.DBProsiga;
using Domain.Interfaces.Services.DBProsiga;
using Domain.Services.Base;

namespace Domain.Services.DBProsiga
{
    public class CepcorreioService : ServiceBase<Cepcorreio>, ICepcorreioService
    {
        private readonly ICepcorreioRepository _Repository;
        public CepcorreioService(ICepcorreioRepository repository) : base(repository)
        {
            _Repository = _Repository;
        }
    }
}
