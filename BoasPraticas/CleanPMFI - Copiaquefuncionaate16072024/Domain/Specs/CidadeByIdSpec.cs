using Domain.Builders;
using Domain.Entities;
using Domain.Filters;
using Domain.Specifications;

namespace Domain.Specs;

public class CidadeByIdSpec : SingleResultSpecification<Cidade>
{
    public CidadeByIdSpec(int id)
    {
        Query.Where(x => x.IdCidade == id);
    }
    public CidadeByIdSpec(CidadeFilter cidadeFilter)
    {
        Query.Where(x => x.IdCidade == cidadeFilter.IdCidade);
        
    }
}
