

using PMFI.Domain.Entities;
using PMFI.Domain.Filters;

namespace PMFI.Domain.Specs;

public class CidadeSpec : Specification<Cidade>
{
    public CidadeSpec()
    {
        Query.Include(c => c.Addresses)
            .ApplyOrdering()
            .TagWith("List all customers.");
    }
    public CidadeSpec(CidadeFilter filter)
    {
        Query.Include(x => x.Addresses)
            .Where(c => c.Age >= filter.AgeFrom, filter.AgeFrom is not null)
            .Where(c => c.Age <= filter.AgeTo, filter.AgeTo is not null)
            .Where(c => c.Name == filter.Name, filter.Name is not null)
            .ApplyOrdering(filter)
            .TagWith("List customers filtered by user inputs.");
    }
}
