using Domain.Builders;
using Domain.Entities;
using Domain.Filters;
using Domain.Specifications;

namespace Domain.Specs;

public class TribAlvDocumentoByInscricaoSpec : SingleResultSpecification<TribAlvDocumento>
{
    public TribAlvDocumentoByInscricaoSpec(string inscricao)
    {
        Query.Where(x => x.NrInscricao == inscricao);
    }
    public TribAlvDocumentoByInscricaoSpec(TribAlvDocumentoFilter tribAlvDocumentoFilter)
    {
        Query.Where(x => x.NrInscricao == tribAlvDocumentoFilter.NrInscricao);
        
    }
}
