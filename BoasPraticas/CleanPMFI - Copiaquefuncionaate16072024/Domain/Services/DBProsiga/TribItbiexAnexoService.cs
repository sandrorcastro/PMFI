using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Repositories.DBProsiga;
using Domain.Interfaces.Services.DBProsiga;
using Domain.Services.Base;

namespace Domain.Services.DBProsiga
{
    public class TribItbiexAnexoService : ServiceBase<TribItbiexAnexo>, ITribItbiexAnexoService
    {
        private readonly ITribItbiexAnexoRepository _Repository;

        public TribItbiexAnexoService(ITribItbiexAnexoRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }
      /*  public TribItbiexAnexoService(IRepositoryBase<TribItbiexAnexo> _repository) : base(_repository)
        {
        }*/
    }
}
