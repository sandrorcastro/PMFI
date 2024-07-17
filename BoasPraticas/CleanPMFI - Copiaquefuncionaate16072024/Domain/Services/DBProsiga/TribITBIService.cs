using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Repositories.DBProsiga;
using Domain.Interfaces.Services.DBProsiga;
using Domain.Services.Base;

namespace Domain.Services.DBProsiga
{
    public class TribITBIService : ServiceBase<TribItbi>, ITribITBIService
    {
        private readonly ITribITBIRepository _Repository;

        public TribITBIService(ITribITBIRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }
      /*  public TribITBIService(IRepositoryBase<TribITBI> _repository) : base(_repository)
        {
        }*/
    }
}
