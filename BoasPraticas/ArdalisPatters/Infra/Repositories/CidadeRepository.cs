using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infra.Context;
using Infra.Specification.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class CidadeRepository : RepositoryBase<Cidade>, ICidadeRepository
    {
        public CidadeRepository(AppDbContext _contextFactory) : base(_contextFactory)
        {
        }
    }
}
