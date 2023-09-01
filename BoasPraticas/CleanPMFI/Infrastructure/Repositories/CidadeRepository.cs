using AutoMapper;
using Domain.Entities;
using Domain.Interfaces.Evaluators;
using Domain.Interfaces.Repositories;
using Infrastructure.Context;
using Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class CidadeRepository : RepositoryBase<Cidade>, ICidadeRepository
    {
        public CidadeRepository(ApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper){ }
        public CidadeRepository(ApplicationDbContext dbContext, ISpecificationEvaluator specificationEvaluator, IMapper mapper) : base(dbContext, specificationEvaluator, mapper){ }

    }
}
