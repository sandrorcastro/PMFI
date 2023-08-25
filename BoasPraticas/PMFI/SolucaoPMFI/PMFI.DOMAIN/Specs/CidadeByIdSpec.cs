

using PMFI.Domain.Builder;
using PMFI.Domain.Entities;
using PMFI.Domain.Specifications;

namespace PMFI.Domain.Specs;

public class CidadeByIdSpec : SingleResultSpecification<Cidade>
{
    public CidadeByIdSpec(int id)
    {
        Query.Where(x => x.IdCidade == id);
            //.Include(x => x.);
    }
}
