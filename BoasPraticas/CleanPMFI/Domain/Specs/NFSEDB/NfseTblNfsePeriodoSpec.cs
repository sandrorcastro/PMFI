using Domain.Builders;
using Domain.Entities;
using Domain.Entities.NFSEDB;
using Domain.Filters;
using Domain.Specifications;

namespace Domain.Specs;
public class NfseTblNfsePeriodoSpec : Specification<NfseTblNfse>
{
    IQueryable<NfseTblNfse> queryable;
    public NfseTblNfsePeriodoSpec()
    {
        Query.ApplyOrdering().TagWith("Lista todas as Notas Fiscais Eletrônicas");
    }
    public NfseTblNfsePeriodoSpec(NfseTblNfseFilter filter)
    {
        Query.Where(c => c.Dtcompetencia >= filter.DataInicial && c.Dtcompetencia < filter.DataFinal);
    }
}
