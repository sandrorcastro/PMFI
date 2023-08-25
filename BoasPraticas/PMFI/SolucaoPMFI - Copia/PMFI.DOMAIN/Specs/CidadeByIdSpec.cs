

using PMFI.Domain.Entities;

namespace PMFI.Domain.Specs;

public class CidadeByIdSpec : SingleResultSpecification<Cidade>
{
    public CidadeByIdSpec(int id)
    {
        Query.Where(x => x.Id == id)
            .Include(x => x.Addresses);
    }
}
