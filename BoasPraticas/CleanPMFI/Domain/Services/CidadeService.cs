using Domain.Entities;
using Domain.Interfaces.Base;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Services.Base;

namespace Domain.Services
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
