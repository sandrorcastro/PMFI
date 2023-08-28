using Domain.Entities;
using Domain.Interfaces.Services;
using Domain.Services.Base;
using Domain.Specification;

namespace Domain.Services
{
    public class CidadeService : ServiceBase<Cidade>, ICidadeService
    {
        public CidadeService(IRepositoryBase<Cidade> _repository) : base(_repository)
        {
        }
    }
}
