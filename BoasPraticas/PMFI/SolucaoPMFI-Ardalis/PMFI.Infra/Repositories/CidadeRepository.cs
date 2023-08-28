using Microsoft.EntityFrameworkCore;
using PMFI.Domain.Entities;
using PMFI.Domain.Interfaces.Repositories;
using PMFI.Infra.Context;
using PMFI.Infra.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMFI.Infra.Repositories
{
    public class CidadeRepository : RepositoryBase<Cidade>, ICidadeRepository
    {
        public CidadeRepository(IDbContextFactory<ApplicationDbContext> _contextFactory) : base(_contextFactory)
        {
        }
    }
}
