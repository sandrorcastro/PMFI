using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using MVC.Models;
using System.Linq.Expressions;

namespace MVC.Extensions
{
   // [Authorize]
    public static class ImovelQueryExtensions
    {
        public static IQueryable<Imovel> Filter(this IQueryable<Imovel> query, string filter)
        {
            
            if (string.IsNullOrWhiteSpace(filter))
            {
                //return query.Where(s=>s.ServidorId==long.Parse("2289401"));
                return query;
            }
            long number1 = 0;
            //if (long.TryParse(filter, out number1))
            //{
                return query.Where(s => s.ImovelId == long.Parse(filter) );
            //}
            
        }

        public static IQueryable<Imovel> OrderBy(this IQueryable<Imovel> query, string name, SortDirection? direction = SortDirection.Asc)
        {
            Expression<Func<Imovel, object>> exp = name /*? ToLower()*/ switch
            {
                "ImovelId" => x => x.ImovelId
                
            };

            return direction == SortDirection.Asc ? query.OrderBy(exp) : query.OrderByDescending(exp);
        }
        /*public static IQueryable<Imovel> Permissao(this IQueryable<Imovel> query, long permissao)
        {
            return query.Where(s=>s.ServidorId==permissao); 
        }*/
    }
}
