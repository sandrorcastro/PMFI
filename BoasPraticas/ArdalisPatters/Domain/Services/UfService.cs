using Domain.Entities;
using Domain.Interfaces.Services;
using Domain.Services.Base;
using Domain.Specification;

namespace Domain.Services
{
    public class UfService : ServiceBase<Uf>, IUfService
    {
        public UfService(IRepositoryBase<Uf> _repository) : base(_repository)
        {
        }
    }
}
