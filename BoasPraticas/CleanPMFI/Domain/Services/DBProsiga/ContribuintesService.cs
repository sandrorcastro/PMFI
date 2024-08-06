using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Repositories.DBProsiga;
using Domain.Interfaces.Services.DBProsiga;
using Domain.Services.Base;

namespace Domain.Services.DBProsiga
{
    public class ContribuintesService : ServiceBase<Contribuinte>, IContribuintesService
    {
        private readonly IContribuintesRepository _Repository;

        public ContribuintesService(IContribuintesRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }
      /*  public ContribuinteService(IRepositoryBase<Contribuinte> _repository) : base(_repository)
        {
        }*/
    }
}
