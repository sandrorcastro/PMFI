using Domain.Builders;
using Domain.Entities;
using Domain.Specifications;

namespace Domain.Specs;

public class CidadeByIdSpec : SingleResultSpecification<Cidade>
{
    public CidadeByIdSpec(int id)
    {
        Query.Where(x => x.IdCidade == id);
    }
}
