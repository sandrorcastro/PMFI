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
    public class TipoResponsabilidadeRepository : RepositoryBase<TipoResponsabilidade>, ITipoResponsabilidadeRepository
    {
        // private readonly IDbContextFactory<ContextoAplicacao> contexto;
       // private readonly ContextoAplicacao contexto;
        //public TipoResponsabilidadeRepository(IDbContextFactory<ContextoAplicacao> contexto) : base(contexto) { }
        public TipoResponsabilidadeRepository(ContextoAplicacao contexto) : base(contexto) { }


    }
}
