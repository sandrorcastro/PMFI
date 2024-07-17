using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Repositories.DBProsiga;
using Domain.Interfaces.Services.DBProsiga;
using Domain.Services.Base;

namespace Domain.Services.DBProsiga
{
    public class TribITBIEdifService : ServiceBase<TribItbiedif>, ITribITBIEdifService
    {
        private readonly ITribITBIEdifRepository _Repository;

        public TribITBIEdifService(ITribITBIEdifRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }
      /*  public TribITBIEdifService(IRepositoryBase<TribITBIEdif> _repository) : base(_repository)
        {
        }*/
    }
}
