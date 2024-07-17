using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Repositories.DBProsiga;
using Domain.Interfaces.Services.DBProsiga;
using Domain.Services.Base;

namespace Domain.Services.DBProsiga
{
    public class TribITBIVendedoresService : ServiceBase<TribItbivendedore>, ITribITBIVendedoresService
    {
        private readonly ITribITBIVendedoresRepository _Repository;

        public TribITBIVendedoresService(ITribITBIVendedoresRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }
      /*  public TribITBIVendedoresService(IRepositoryBase<TribITBIVendedores> _repository) : base(_repository)
        {
        }*/
    }
}
