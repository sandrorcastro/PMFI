

using PMFI.Domain.Entities;
using PMFI.Domain.Interfaces.Services;
using PMFI.Domain.Services.Base;
using PMIFI.Domain.Interfaces.Base;

namespace PMFI.Domain.Services
{
    public class CidadeService : ServiceBase<Cidade>, ICidadeService
    {
        public CidadeService(IRepositoryBase<Cidade> _repository) : base(_repository)
        {
        }
    }
}
