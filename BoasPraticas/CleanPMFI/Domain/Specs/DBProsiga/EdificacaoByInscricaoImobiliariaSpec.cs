using Domain.Builders;
using Domain.Entities.DBProsiga;
using Domain.Filters.DBProsiga;
using Domain.Specifications;

namespace Domain.Specs;

public class EdificacaoByInscricaoImobiliariaSpec : SingleResultSpecification<TribEdificaco>
{
    public EdificacaoByInscricaoImobiliariaSpec(string inscricaoimobiliaria)
    {
        Query.Where(x => x.InscricaoImobiliaria == inscricaoimobiliaria);
    }
    public EdificacaoByInscricaoImobiliariaSpec(EdificacaoFilter edificacaoFilter)
    {
        Query.Where(x => x.InscricaoImobiliaria == edificacaoFilter.InscricaoImobiliaria);
        
    }
}
