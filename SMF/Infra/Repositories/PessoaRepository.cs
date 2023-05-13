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
    public class PessoaRepository : RepositoryBase<Pessoa>, IPessoaRepository
    {
        //private readonly IDbContextFactory<ContextoAplicacao> contexto;
        //private readonly ContextoAplicacao contexto;
        //public PessoaRepository(IDbContextFactory<ContextoAplicacao> contexto) : base(contexto) { }
        public PessoaRepository(ContextoAplicacao contexto) : base(contexto) { }

        public IEnumerable<Pessoa> BuscarPorNome(string nome)
        {
           // using (var Db = contexto.CreateDbContext())
            //{
                return contexto.dbSPessoas.Where(p => p.Nome == nome);
            //}
        }
        public Pessoa GetById(long id)
        {
           // using (var Db = contexto.CreateDbContext())
           // {
                return contexto.dbSPessoas.Where(p => p.PessoaId == id).Include(tp => tp.TipoPessoa).FirstOrDefault();
           // }
        }
    }
}
