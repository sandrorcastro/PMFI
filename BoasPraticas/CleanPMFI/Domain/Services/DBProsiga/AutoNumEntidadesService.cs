using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Repositories.DBProsiga;
using Domain.Interfaces.Services.DBProsiga;
using Domain.Services.Base;

namespace Domain.Services.DBProsiga
{
    public class AutoNumEntidadesService : ServiceBase<AutoNumEntidade>, IAutoNumEntidadesService
    {
        private readonly IAutoNumEntidadesRepository _Repository;

        public AutoNumEntidadesService(IAutoNumEntidadesRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }
      /*  public AutoNumEntidadesService(IRepositoryBase<AutoNumEntidades> _repository) : base(_repository)
        {
        }*/
    }
}
