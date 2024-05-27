using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Repositories.DBProsiga;
using Domain.Interfaces.Services.DBProsiga;
using Domain.Services.Base;

namespace Domain.Services.DBProsiga
{
    public class TribITBICompradoresService : ServiceBase<TribItbicompradore>, ITribITBICompradoresService
    {
        private readonly ITribITBICompradoresRepository _Repository;

        public TribITBICompradoresService(ITribITBICompradoresRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }
      /*  public TribITBICompradoresService(IRepositoryBase<TribITBICompradores> _repository) : base(_repository)
        {
        }*/
    }
}
