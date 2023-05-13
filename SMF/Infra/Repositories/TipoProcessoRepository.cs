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
    public class TipoProcessoRepository : RepositoryBase<TipoProcesso>, ITipoProcessoRepository
    {
        // private readonly IDbContextFactory<ContextoAplicacao> contexto;
        //private readonly ContextoAplicacao contexto;
        //public TipoProcessoRepository(IDbContextFactory<ContextoAplicacao> contexto) : base(contexto) { }
        public TipoProcessoRepository(ContextoAplicacao contexto) : base(contexto) { }


    }
}
