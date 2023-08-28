

using PMFI.Domain.Entities;
using PMFI.Domain.Interfaces.Repositories;
using PMFI.Domain.Interfaces.Services;

namespace PMFI.Domain.Services
{
    public class UfService : ServiceBase<Uf>, IUfService
    {
        public UfService(IRepositoryBase<Uf> _repository) : base(_repository)
        {
        }
    }
}
