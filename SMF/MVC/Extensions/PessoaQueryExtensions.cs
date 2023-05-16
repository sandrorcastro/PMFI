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
                return query.Include(tp=>tp.TipoPessoa);
            }
            long number1 = 0;
            if (long.TryParse(filter, out number1))
            {
               return query.Where(s => s.PessoaId == long.Parse(filter) ).Include(tp=>tp.TipoPessoa);
            }
            else
            {
                return query.Where(s => s.Nome.Contains(filter)).Include(tp => tp.TipoPessoa);
            }
            
        }

        public static IQueryable<Pessoa> OrderBy(this IQueryable<Pessoa> query, string name, SortDirection? direction = SortDirection.Asc)
        {
            Expression<Func<Pessoa, object>> exp = name?.ToLower() switch
            {
                "" => x => x.Nome,
                "DataCadastro" => x => x.DataCadastro,
                "PessoaId" => x => x.PessoaId,
                "Nome" => x => x.Nome,
                "TipoPessoa" => x => x.TipoPessoa.Descricao,
                "conId" => x => x.conId,


            };

            return direction == SortDirection.Asc ? query.OrderBy(exp) : query.OrderByDescending(exp);
        }
        /*public static IQueryable<Pessoa> Permissao(this IQueryable<Pessoa> query, long permissao)
        {
            return query.Where(s=>s.ServidorId==permissao); 
        }*/
    }
}
