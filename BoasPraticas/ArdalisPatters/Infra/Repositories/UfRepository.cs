using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infra.Specification.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PMFI.Infra.Repositories
{
    public class UfRepository : RepositoryBase<Uf>, IUfRepository
    {
        public UfRepository(DbContext _contextFactory) : base(_contextFactory)
        {
        }
    }
}
