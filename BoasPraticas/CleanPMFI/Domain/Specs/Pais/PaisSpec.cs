using Domain.Builders;
using Domain.Entities;
using Domain.Filters;
using Domain.Specifications;

namespace Domain.Specs;
public class PaisSpec : Specification<Pais>
{
    
    public PaisSpec()
    {
        Query.ApplyOrdering().TagWith("List all Paises");
    }
    public PaisSpec(PaisFilter filter)
    {
        Query.Where(c => c.Nome == filter.Nome, filter.Nome is not null).ApplyOrdering(filter).TagWith("List Paises filtered by user inputs.");
    }
}
