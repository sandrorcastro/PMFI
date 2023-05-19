using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.CodeAnalysis.Host.Mef;
using Microsoft.EntityFrameworkCore;
using MVC.Models;
using System.Linq.Expressions;

namespace MVC.Extensions
{
   // [Authorize]
    public static class LogradouroQueryExtensions
    {
        public static IQueryable<Logradouro> Filter(this IQueryable<Logradouro> query, string filter)
        {
            
            if (string.IsNullOrWhiteSpace(filter))
            {
                //return query.Where(s=>s.ServidorId==long.Parse("2289401"));
                return query.Take(100).Include(tl=>tl.TipoLogradouro);
            }
            long number1 = 0;
            if (long.TryParse(filter, out number1))
            {
                return query.Where(s => s.LogradouroId == long.Parse(filter)
                                        || s.TipoLogradouroId == long.Parse(filter)
                                    ).Include(tl => tl.TipoLogradouro);
            }
            else {
                return query.Where(s => s.Descricao.Contains(filter)
                                        || s.TipoLogradouro.Descricao.Contains(filter)
                                    ).Include(tl => tl.TipoLogradouro);
            }
            
        }

        public static IQueryable<Logradouro> OrderBy(this IQueryable<Logradouro> query, string sort, SortDirection? direction = SortDirection.Asc)
        {
            if (string.IsNullOrWhiteSpace(sort))
            {
                sort = "";
            }
            Expression<Func<Logradouro, object>> exp = sort?.ToLower() switch
            {
                "" => x => x.LogradouroId,
                "logradourpid" => x => x.LogradouroId,
                "logradourodescricao" => x => x.Descricao


            };

            return direction == SortDirection.Asc ? query.OrderBy(exp) : query.OrderByDescending(exp);
        }
        /*public static IQueryable<Logradouro> Permissao(this IQueryable<Logradouro> query, long permissao)
        {
            return query.Where(s=>s.ServidorId==permissao); 
        }*/
    }
}
