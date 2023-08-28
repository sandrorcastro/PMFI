using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infra.Specification.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class PaisRepository : RepositoryBase<Pais>, IPaisRepository
    {
        public PaisRepository(DbContext _contextFactory) : base(_contextFactory)
        {
        }
    }
}
