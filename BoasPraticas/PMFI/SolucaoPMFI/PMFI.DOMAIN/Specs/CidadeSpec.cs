

using PMFI.Domain.Entities;
using PMFI.Domain.Filters;
using PMFI.Domain.Specifications;

namespace PMFI.Domain.Specs;

public class CidadeSpec : Specification<Cidade>
{
    public CidadeSpec()
    {
        Query//.Include(c => c.Addresses)
            .ApplyOrdering()
            .TagWith("List all customers.");
    }
    public CidadeSpec(CidadeFilter filter)
    {
        //Query.Include(x => x.Addresses).Where(c => c.Name == filter.Nome, filter.Nome is not null).ApplyOrdering(filter).TagWith("List cidades filtered by user inputs.");
    }
}
