using AutoMapper;
using Domain.Entities;
using Domain.Entities.MegaData;
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
    public class MegaDataRepository : RepositoryBase<MegaData_NFSE>, IMegaDataRepository
    {
         public MegaDataRepository(MegaDataDBContext _contextFactory,IMapper mapper) : base(_contextFactory,mapper) { }
        public MegaDataRepository(MegaDataDBContext dbContext, ISpecificationEvaluator specificationEvaluator, IMapper mapper) : base(dbContext, specificationEvaluator, mapper) { }
    }
}
