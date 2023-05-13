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
    public class TipoLogradouroRepository : RepositoryBase<TipoLogradouro>, ITipoLogradouroRepository
    {
       // private readonly ContextoAplicacao contexto;
        //public TipoLogradouroRepository(IDbContextFactory<ContextoAplicacao> contexto) : base(contexto) { }
        public TipoLogradouroRepository(ContextoAplicacao contexto) : base(contexto) { }

        public IEnumerable<TipoLogradouro> BuscarPorDescricao(string descricao)
        {
            return contexto.dbSTiposLogradouro.Where(p => p.Descricao == descricao);
        }
    }
}
