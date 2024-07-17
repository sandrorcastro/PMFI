using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Repositories.DBProsiga;
using Domain.Interfaces.Services.DBProsiga;
using Domain.Services.Base;

namespace Domain.Services.DBProsiga
{
    public class CidadeService : ServiceBase<Cidade>, ICidadeService
    {
        private readonly ICidadeRepository _Repository;

        public CidadeService(ICidadeRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }
      /*  public CidadeService(IRepositoryBase<Cidade> _repository) : base(_repository)
        {
        }*/
    }
}
