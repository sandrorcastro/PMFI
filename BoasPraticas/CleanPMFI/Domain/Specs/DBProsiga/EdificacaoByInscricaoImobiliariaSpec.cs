using Domain.Builders;
using Domain.Entities;
using Domain.Entities.DBProsiga;
using Domain.Filters.DBProsiga;
using Domain.Specifications;
using System.Linq.Expressions;

namespace Domain.Specs.DBProsiga;

public class EdificacaoByInscricaoImobiliariaSpec : SingleResultSpecification<TribEdificaco>
{
    //public string? InscricaoImobiliaria { get; set; }

    public EdificacaoByInscricaoImobiliariaSpec(string inscricaoimobiliaria)

    {
        //InscricaoImobiliaria = _inscricaoimobiliaria;
        //Query.Where(x => x.InscricaoImobiliaria == inscricaoimobiliaria && x.EdifSituacao=="Normal" && ((x.EdifCaracteristica=="Predial" && x.EdifContinuacaoTerreno=="Não")||(x.EdifCaracteristica == "Territorial" && x.EdifContinuacaoTerreno == "Sim"))).Include(t => t.Terreno).Include(l => l.Lograd).ThenInclude(q=>q.TribQuadraLograds).Include(l => l.IdloteamentoNavigation).Include(c => c.TribEdificacoesContribs).ThenInclude(x => x.Con);
        Query.Where(x => x.InscricaoImobiliaria == inscricaoimobiliaria).Include(t => t.Terreno).Include(l => l.Lograd).ThenInclude(q => q.TribQuadraLograds).Include(l => l.IdloteamentoNavigation).Include(c => c.TribEdificacoesContribs).ThenInclude(x => x.Con);
        //Query.Include(t => t.Terreno).Include(l => l.Lograd).Include(l => l.IdloteamentoNavigation).Include(c => c.TribEdificacoesContribs).ThenInclude(x => x.Con); //.AsQueryable();
    }   
    public EdificacaoByInscricaoImobiliariaSpec(EdificacaoFilter edificacaoFilter)
    {

        Query.Where(x => x.InscricaoImobiliaria == edificacaoFilter.InscricaoImobiliaria);

    }
    /*public Expression<Func<TribEdificaco, bool>> ToExpression()
    {
            return x => x.InscricaoImobiliaria == InscricaoImobiliaria;
        }*/

    
}
