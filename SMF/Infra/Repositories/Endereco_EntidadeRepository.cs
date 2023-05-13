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
    public class Endereco_EntidadeRepository : RepositoryBase<Endereco_Entidade>, IEndereco_EntidadeRepository
    {
        // private readonly IDbContextFactory<ContextoAplicacao> contexto;
        //private readonly ContextoAplicacao contexto;
        //public EnderecoEntidadeRepository(IDbContextFactory<ContextoAplicacao> contexto) : base(contexto) { }
        public Endereco_EntidadeRepository(ContextoAplicacao contexto) : base(contexto) { }

        public IEnumerable<Endereco_Entidade> BuscarPorDescricao(string descricao)
        {
            //using (var Db = contexto.CreateDbContext())
            //{
                return contexto.dbSEnderecos_Entidades.Where(p => p.Endereco.Logradouro.Descricao == descricao);
            //}
        }
    }
}
