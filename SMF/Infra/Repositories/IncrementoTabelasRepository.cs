using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class IncrementoTabelasRepository : RepositoryBase<IncrementoTabelas>, IIncrementoTabelasRepository
    {
        //private readonly IDbContextFactory<ContextoAplicacao> contexto;
        //private readonly ContextoAplicacao contexto;
        //public IncrementoTabelasRepository(IDbContextFactory<ContextoAplicacao> contexto) : base(contexto) { }
        public IncrementoTabelasRepository(ContextoAplicacao contexto) : base(contexto) { contexto = contexto; }

        public IncrementoTabelas BuscarPorTabela(string tabela)
        {
          //  using (var Db = contexto.CreateDbContext())
            //{
                return contexto.dbSIncrementoTabelas.Where(p => p.Tabela == tabela).FirstOrDefault();
            //}
        }

        public long Incrementar(string tabela, string parametro, string ano)
        {
            //using (var Db = contexto.CreateDbContext())
            //{
                IncrementoTabelas IT = new IncrementoTabelas();
                IT.Tabela = tabela;
                IT.Parametro = parametro;
                IT.Ano = ano;
                IT = contexto.dbSIncrementoTabelas.Where(i => i.Tabela == IT.Tabela && i.Parametro == IT.Parametro && i.Ano == IT.Ano).FirstOrDefault();
                IT.valorAtual = IT.valorAtual + IT.valorincrementar;
                var atualizado = contexto.dbSIncrementoTabelas.Update(IT);
                return (long)IT.valorAtual;
            //}
        }

        public long ValorAtual(string? tabela, string? parametro, string? ano)
        {
           // using (var Db = contexto.CreateDbContext())
            //{
                IncrementoTabelas IT = new IncrementoTabelas();
                IT.Tabela = tabela;
                IT.Parametro = parametro;
                IT.Ano = ano;
                return (long) contexto.dbSIncrementoTabelas.Find(IT).valorAtual;
            //}
        }
    }
}
