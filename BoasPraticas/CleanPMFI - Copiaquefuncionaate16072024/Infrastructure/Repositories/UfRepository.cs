using AutoMapper;
using Domain.Entities;
using Domain.Interfaces.Evaluators;
using Domain.Interfaces.Repositories;
using Infrastructure.Context;
using Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UfRepository : RepositoryBase<Uf>, IUfRepository
    {
         public UfRepository(ApplicationDbContext _contextFactory,IMapper mapper) : base(_contextFactory,mapper) { }
        public UfRepository(ApplicationDbContext dbContext, ISpecificationEvaluator specificationEvaluator, IMapper mapper) : base(dbContext, specificationEvaluator, mapper) { }
    }
}
