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
    public class EnderecoRepository : RepositoryBase<Endereco>, IEnderecoRepository
    {
        //private readonly IDbContextFactory<ContextoAplicacao> contexto;
        //private readonly ContextoAplicacao contexto;
        //public EnderecoRepository(IDbContextFactory<ContextoAplicacao> contexto) : base(contexto) { }
        public EnderecoRepository(ContextoAplicacao contexto) : base(contexto) { }

        public IEnumerable<Endereco> BuscarPorDescricao(string descricao)
        {
            //using (var Db = contexto.CreateDbContext())
            //{
                return contexto.dbSEnderecos.Where(p => p.Logradouro.Descricao == descricao);
            //}
        }
    }
}
