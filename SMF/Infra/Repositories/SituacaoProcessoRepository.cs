using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infra.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class SituacaoProcessoRepository : RepositoryBase<SituacaoProcesso>, ISituacaoProcessoRepository
    {
        //private readonly IDbContextFactory<ContextoAplicacao> contexto;
        //private readonly ContextoAplicacao contexto;
        //public SituacaoProcessoRepository(IDbContextFactory<ContextoAplicacao> contexto) : base(contexto) { }
        public SituacaoProcessoRepository(ContextoAplicacao contexto) : base(contexto) { }


    }
}
