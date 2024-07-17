using Domain.Builders;
using Domain.Entities;
using Domain.Entities.NFSEDB;
using Domain.Filters;
using Domain.Specifications;

namespace Domain.Specs;
public class NfseTblNfseSpec : Specification<NfseTblNfse>
{
    IQueryable<NfseTblNfse> queryable;
    public NfseTblNfseSpec()
    {
        Query.ApplyOrdering().TagWith("Lista todas as Notas Fiscais Eletrônicas");
    }
    public NfseTblNfseSpec(NfseTblNfseFilter filter)
    {
        Query.Where(c => c.Dtcompetencia >= filter.DataInicial && c.Dtcompetencia < filter.DataFinal,filter.Dtcompetencia is not null).ApplyOrdering(filter).TagWith("Notas Fiscais No Período desejado!");
    }
}
