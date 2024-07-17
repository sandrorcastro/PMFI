using AutoMapper;
using Domain.Entities.DBProsiga;
using Domain.Interfaces.Evaluators;
using Domain.Interfaces.Repositories.DBProsiga;
using Infrastructure.Context.DBProsiga;
using Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.DBProsiga
{
    public class LogradouroTipoRepository : RepositoryBase<Logradourotipo>, ILogradouroTipoRepository
    {
         public LogradouroTipoRepository(DBProsigaContext _contextFactory,IMapper mapper) : base(_contextFactory,mapper) { }
        public LogradouroTipoRepository(DBProsigaContext dbContext, ISpecificationEvaluator specificationEvaluator, IMapper mapper) : base(dbContext, specificationEvaluator, mapper) { }
    }
}
