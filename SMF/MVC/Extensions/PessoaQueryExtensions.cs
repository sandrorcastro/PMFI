using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using MVC.Models;
using System.Linq.Expressions;

namespace MVC.Extensions
{
   // [Authorize]
    public static class PessoaQueryExtensions
    {
        public static IQueryable<Pessoa> Filter(this IQueryable<Pessoa> query, string filter)
        {
            
            if (string.IsNullOrWhiteSpace(filter))
            {
                //return query.Where(s=>s.ServidorId==long.Parse("2289401"));
                return query.Include(tp=>tp.TipoPessoa).Take(100);
            }
            long number1 = 0;
            if (long.TryParse(filter, out number1))
            {
               return query.Where(  s => s.PessoaId == long.Parse(filter) 
                                      || s.conId == long.Parse(filter)
                                 ).Include(tp=>tp.TipoPessoa);
            }
            else
            {
                return query.Where( s => s.Nome.Contains(filter)
                                      || s.TipoPessoa.Descricao.Contains(filter)
                                  ).Include(tp => tp.TipoPessoa);
            }
            
        }

        public static IQueryable<Pessoa> OrderBy(this IQueryable<Pessoa> query, string sort, SortDirection? direction = SortDirection.Asc)
        {
            if (string.IsNullOrWhiteSpace(sort)) {
                sort = "";
            }
             Expression<Func<Pessoa, object>> exp = sort?.ToLower() switch
            {
                "" => x => x.Nome,
                "datacadastro" => x => x.DataCadastro,
                "pessoaid" => x => x.PessoaId,
                "nome" => x => x.Nome,
                "tipopessoa" => x => x.TipoPessoa.Descricao,
                "conid" => x => x.conId,
                "ativo" => x => x.Ativo,
            };

            return direction == SortDirection.Asc ? query.OrderBy(exp) : query.OrderByDescending(exp);
        }
        /*public static IQueryable<Pessoa> Permissao(this IQueryable<Pessoa> query, long permissao)
        {
            return query.Where(s=>s.ServidorId==permissao); 
        }*/
    }
}
