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
    public class ProcessoRepository : RepositoryBase<Processo>, IProcessoRepository
    {
        //private readonly IDbContextFactory<ContextoAplicacao> contexto;
       // private readonly ContextoAplicacao contexto;
        //public ProcessoRepository(IDbContextFactory<ContextoAplicacao> contexto) : base(contexto) { }
        public ProcessoRepository(ContextoAplicacao contexto) : base(contexto) { }


    }
}
