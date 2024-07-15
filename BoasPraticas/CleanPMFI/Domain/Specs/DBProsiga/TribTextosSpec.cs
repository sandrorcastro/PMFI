using Domain.Builders;
using Domain.Entities;
using Domain.Entities.DBProsiga;
using Domain.Filters.DBProsiga;
using Domain.Specifications;
using System.Linq.Expressions;

namespace Domain.Specs.DBProsiga;

public class TribTextosSpec : SingleResultSpecification<TribTexto>
{
   

  /*  public SisParametrosSpec(long? itbidicid,string? descricao)

    {
        //InscricaoImobiliaria = _inscricaoimobiliaria;
        Query.Where(x => x.ItbidocId == itbidicid && x.ItbidsDocDescricao==descricao);
        //Query.Include(t => t.Terreno).Include(l => l.Lograd).Include(l => l.IdloteamentoNavigation).Include(c => c.TribEdificacoesContribs).ThenInclude(x => x.Con); //.AsQueryable();
    }*/
    public TribTextosSpec(long textoID)

    {
        //InscricaoImobiliaria = _inscricaoimobiliaria;
        Query.Where(x => x.TextoId == textoID).AsNoTracking();
        //Query.Include(t => t.Terreno).Include(l => l.Lograd).Include(l => l.IdloteamentoNavigation).Include(c => c.TribEdificacoesContribs).ThenInclude(x => x.Con); //.AsQueryable();
    }
    /*public SisParametrosSpec(EdificacaoFilter edificacaoFilter)
    {

        Query.Where(x => x.InscricaoImobiliaria == edificacaoFilter.InscricaoImobiliaria);

    }*/
    /*public Expression<Func<TribEdificaco, bool>> ToExpression()
    {
            return x => x.InscricaoImobiliaria == InscricaoImobiliaria;
        }*/


}
