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
    public class PessoaJuridicaRepository : RepositoryBase<PessoaJuridica>, IPessoaJuridicaRepository
    {
        //private readonly IDbContextFactory<ContextoAplicacao> contexto;
        //private readonly ContextoAplicacao contexto;
        //public PessoaJuridicaRepository(IDbContextFactory<ContextoAplicacao> contexto) : base(contexto) { }
        public PessoaJuridicaRepository(ContextoAplicacao contexto) : base(contexto) { }

        public IEnumerable<PessoaJuridica> BuscarPorNome(string nome)
        {
            //using (var Db = contexto.CreateDbContext())
            //{
                return contexto.dbSPessoasJuridica.Where(p => p.Nome == nome);
            //}
        }
     /*   public PessoaJuridica GetById(long id)
        {
            //using (var Db = contexto.CreateDbContext())
            //{
                return contexto.dbSPessoasJuridica.Where(p => p.PessoaId == id).Include(tp => tp.TipoPessoa).FirstOrDefault();
            //}
        }*/
    }
}
