using Domain.Builders;
using Domain.Entities;
using Domain.Filters;
using Domain.Specifications;

namespace Domain.Specs;
public class CidadeSpec : Specification<Cidade>
{
    public CidadeSpec()
    {
        Query.ApplyOrdering().TagWith("List all cidades");
    }
    public CidadeSpec(CidadeFilter filter)
    {
        Query.Where(c => c.Nome == filter.Nome, filter.Nome is not null); //.ApplyOrdering(filter).TagWith("List customers filtered by user inputs.");
    }
}
