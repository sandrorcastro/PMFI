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
    public class PessoaFisicaRepository : RepositoryBase<PessoaFisica>, IPessoaFisicaRepository
    {
        // private readonly IDbContextFactory<ContextoAplicacao> contexto;
        //private readonly ContextoAplicacao contexto;
        //public PessoaFisicaRepository(IDbContextFactory<ContextoAplicacao> contexto) : base(contexto) { }
        public PessoaFisicaRepository(ContextoAplicacao contexto) : base(contexto) { }

        public IEnumerable<PessoaFisica> BuscarPorNome(string nome)
        {
            //using (var Db = contexto.CreateDbContext())
            //{
                return contexto.dbSPessoasFisica.Where(p => p.Nome == nome);
            //}
        }
       /* public PessoaFisica GetById(long id)
        {
            //using (var Db = contexto.CreateDbContext())
            //{
                return contexto.dbSPessoasFisica.Where(p => p.PessoaId == id).Include(tp => tp.TipoPessoa).Include(p => p.Pais).FirstOrDefault();
            //}
        }*/
    }
}
