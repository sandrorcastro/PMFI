using Domain.Builders;
using Domain.Entities;
using Domain.Filters;
using Domain.Specifications;

namespace Domain.Specs;
public class TribAlvDocumentoSpec : Specification<TribAlvDocumento>
{
    
    public TribAlvDocumentoSpec()
    {
        Query.ApplyOrdering().TagWith("List all Paises");
    }
    public TribAlvDocumentoSpec(TribAlvDocumentoFilter filter)
    {
        Query.Where(c => c.NrAno == filter.NrAno, filter.NrAno is not null).ApplyOrdering(filter).TagWith("Lista Alvaras filtrados.");
    }
}
