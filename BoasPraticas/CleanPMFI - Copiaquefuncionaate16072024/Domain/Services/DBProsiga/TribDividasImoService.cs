using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Repositories.DBProsiga;
using Domain.Interfaces.Services.DBProsiga;
using Domain.Services.Base;

namespace Domain.Services.DBProsiga
{
    public class TribDividasImoService : ServiceBase<TribDividasImo>, ITribDividasImoService
    {
        private readonly ITribDividasImoRepository _Repository;

        public TribDividasImoService(ITribDividasImoRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }
      /*  public TribDividasImoService(IRepositoryBase<TribDividasImo> _repository) : base(_repository)
        {
        }*/
    }
}
