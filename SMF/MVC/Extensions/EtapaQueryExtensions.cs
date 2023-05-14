using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using MVC.Models;
using System.Linq.Expressions;

namespace MVC.Extensions
{
   // [Authorize]
    public static class EtapaQueryExtensions
    {
        public static IQueryable<Etapa> Filter(this IQueryable<Etapa> query, string filter)
        {
            
            if (string.IsNullOrWhiteSpace(filter))
            {
                //return query.Where(s=>s.ServidorId==long.Parse("2289401"));
                return query;
            }
            long number1 = 0;
            if (long.TryParse(filter, out number1))
            {
                return query.Where(s => s.EtapaId == long.Parse(filter)
                                        || s.ProcessoId == long.Parse(filter)
                                        || s.TipoEtapaId == long.Parse(filter)
                                        || s.SituacaoEtapaId == long.Parse(filter)
                                        || s.ImovelId == long.Parse(filter)
                                        || s.EconomiaId == long.Parse(filter)
                                        || s.PessoaId == long.Parse(filter)
                                        || s.ServidorId == long.Parse(filter)

                                          );
            }
            else
            {
                filter = filter.ToLower();
                return query.Where(s => s.ServidorId == long.Parse("2289401") && ( s.Ano.Contains(filter)
                                                                                || s.TipoEtapa.Descricao.Contains(filter)
                                                                                || s.SituacaoEtapa.Descricao.Contains(filter)
                                                                                || s.Servidor.Nome.Contains(filter)
                                                                                || s.Pessoa.Nome.Contains(filter))
                                        );
            }
        }

        public static IQueryable<Etapa> OrderBy(this IQueryable<Etapa> query, string name, SortDirection? direction = SortDirection.Asc)
        {
            Expression<Func<Etapa, object>> exp = name /*? ToLower()*/ switch
            {
                "ProcessoId" => x => x.ProcessoId,
                "EtapaId" => x => x.EtapaId,
                "TipoEtapaId" => x => x.TipoEtapaId,
                "SituacaoEtapaId" => x => x.SituacaoEtapaId,
                "ImovelId" => x => x.ImovelId,
                "EconomiaId" => x => x.EconomiaId,
                "ServidorId" => x => x.ServidorId,
                "DataInicio" => x => x.DataInicio,
                "DataFim" => x => x.DataFim,
                "PessoaId" => x => x.PessoaId
            };

            return direction == SortDirection.Asc ? query.OrderBy(exp) : query.OrderByDescending(exp);
        }
        public static IQueryable<Etapa> Permissao(this IQueryable<Etapa> query, long permissao)
        {
            return query.Where(s=>s.ServidorId==permissao); 
        }
    }
}
