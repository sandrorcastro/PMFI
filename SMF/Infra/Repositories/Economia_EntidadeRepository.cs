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
    public class Economia_EntidadeRepository : RepositoryBase<Economia_Entidade>, IEconomia_EntidadeRepository
    {
        // private readonly IDbContextFactory<ContextoAplicacao> contexto;
        private readonly ContextoAplicacao contexto;
        //public EconomiaPessoaRepository(IDbContextFactory<ContextoAplicacao> contexto) : base(contexto) { }
        public Economia_EntidadeRepository(ContextoAplicacao contexto) : base(contexto) { }


    }
}
