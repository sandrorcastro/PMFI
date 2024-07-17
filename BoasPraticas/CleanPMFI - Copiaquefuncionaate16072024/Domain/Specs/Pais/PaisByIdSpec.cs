using Domain.Builders;
using Domain.Entities;
using Domain.Filters;
using Domain.Specifications;

namespace Domain.Specs;

public class PaisByIdSpec : SingleResultSpecification<Pais>
{
    public PaisByIdSpec(int id)
    {
        Query.Where(x => x.IdPais == id);
    }
    public PaisByIdSpec(PaisFilter cidadeFilter)
    {
        Query.Where(x => x.IdPais == cidadeFilter.IdPais);
        
    }
}
