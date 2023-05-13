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
    public class TipoPessoaRepository : RepositoryBase<TipoPessoa>, ITipoPessoaRepository
    {
        //private readonly IDbContextFactory<ContextoAplicacao> contexto;
       // private readonly ContextoAplicacao contexto;
        //public TipoPessoaRepository(IDbContextFactory<ContextoAplicacao> contexto) : base(contexto) { }
        public TipoPessoaRepository(ContextoAplicacao contexto) : base(contexto) { }

        public IEnumerable<TipoPessoa> BuscarPorDescricao(string descricao)
        {
            //using (var Db = contexto.CreateDbContext())
            //{
                return contexto.dbSTiposPessoa.Where(p => p.Descricao == descricao);
            //}
        }
    }
}
