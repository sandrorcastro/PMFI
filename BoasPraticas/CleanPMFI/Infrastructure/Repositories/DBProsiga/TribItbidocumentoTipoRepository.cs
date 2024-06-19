﻿using AutoMapper;
using Domain.Entities.DBProsiga;
using Domain.Interfaces.Evaluators;
using Domain.Interfaces.Repositories.DBProsiga;
using Infrastructure.Context.DBProsiga;
using Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.DBProsiga
{
    public class TribItbidocumentoTipoRepository : RepositoryBase<TribItbidocumentoTipo>, ITribItbidocumentoTipoRepository
    {
        public TribItbidocumentoTipoRepository(DBProsigaContext dbContext, IMapper mapper) : base(dbContext, mapper){ }
        public TribItbidocumentoTipoRepository(DBProsigaContext dbContext, ISpecificationEvaluator specificationEvaluator, IMapper mapper) : base(dbContext, specificationEvaluator, mapper){ }
        
    }
}