

using PMFI.Domain.Entities;
using PMFI.Domain.Interfaces.Repositories;
using PMFI.Domain.Interfaces.Services;

namespace PMFI.Domain.Services
{
    public class CidadeService : ServiceBase<Cidade>, ICidadeService
    {
        public CidadeService(IRepositoryBase<Cidade> _repository) : base(_repository)
        {
        }
    }
}
