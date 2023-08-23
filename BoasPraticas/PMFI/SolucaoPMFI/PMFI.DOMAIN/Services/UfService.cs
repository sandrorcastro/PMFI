

using PMFI.Domain.Entities;
using PMFI.Domain.Interfaces.Services;
using PMFI.Domain.Services.Base;
using PMIFI.Domain.Interfaces.Base;

namespace PMFI.Domain.Services
{
    public class UfService : ServiceBase<Uf>, IUfService
    {
        public UfService(IRepositoryBase<Uf> _repository) : base(_repository)
        {
        }
    }
}
