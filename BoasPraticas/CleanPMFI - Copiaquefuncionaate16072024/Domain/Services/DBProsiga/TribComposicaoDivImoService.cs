using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Repositories.DBProsiga;
using Domain.Interfaces.Services.DBProsiga;
using Domain.Services.Base;

namespace Domain.Services.DBProsiga
{
    public class TribComposicaoDivImoService : ServiceBase<TribComposicaoDivImo>, ITribComposicaoDivImoService
    {
        private readonly ITribComposicaoDivImoRepository _Repository;

        public TribComposicaoDivImoService(ITribComposicaoDivImoRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }
      /*  public TribComposicaoDivImoService(IRepositoryBase<TribComposicaoDivImo> _repository) : base(_repository)
        {
        }*/
    }
}
