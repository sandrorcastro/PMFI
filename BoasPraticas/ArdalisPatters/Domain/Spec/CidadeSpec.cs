using Domain.Entities;
using Domain.Filters;
using Domain.Specification;

namespace Domains.Spec;

public class CidadeSpec : Specification<Cidade>
{
    public CidadeSpec()
    {
        //Query.ApplyOrdering().TagWith("List all customers.");
    }
    public CidadeSpec(CidadeFilter filter)
    {
       // Query.Where(c => c.Nome== filter.Nome, filter.Nome is not null).ApplyOrdering(filter).TagWith("Lista de Cidades");
    }
}
