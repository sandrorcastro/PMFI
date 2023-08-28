using Domain.Entities;
using Domain.Interfaces.Base;
using Domain.Interfaces.Services;
using Domain.Services.Base;

namespace Domain.Services
{
    public class CidadeService : ServiceBase<Cidade>, ICidadeService
    {
        public CidadeService(IRepositoryBase<Cidade> _repository) : base(_repository)
        {
        }
    }
}
