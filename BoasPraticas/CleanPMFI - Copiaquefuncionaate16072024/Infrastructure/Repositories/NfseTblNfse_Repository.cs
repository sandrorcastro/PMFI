using AutoMapper;
using Domain.Entities;
using Domain.Entities.NFSEDB;
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
    public class NfseTblNfse_Repository : RepositoryBase<NfseTblNfse>, INfseTblNfse_Repository
    {
        //public NfseTblNfse_Repository(ApplicationDbContext _contextFactory,IMapper mapper) : base(_contextFactory,mapper) { }
        public NfseTblNfse_Repository(NFSEDBContext _contextFactory, IMapper mapper) : base(_contextFactory, mapper) { }
        //public NfseTblNfse_Repository(ApplicationDbContext dbContext, ISpecificationEvaluator specificationEvaluator, IMapper mapper) : base(dbContext, specificationEvaluator, mapper) { }
        public NfseTblNfse_Repository(NFSEDBContext dbContext, ISpecificationEvaluator specificationEvaluator, IMapper mapper) : base(dbContext, specificationEvaluator, mapper) { }
    }
}
