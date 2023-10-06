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
        //Query.ApplyOrdering().TagWith("Lista todas as Notas Fiscais Eletrônicas");
    }
    public NfseTblNfseSpec(NfseTblNfseFilter filter)
    {
        //Query.Where(c => c.Dtcompetencia >= filter.Dtcompetencia and filter.Dtcompetencia<= filter.Dtcompetencia,filter.Dtcompetencia is not null).ApplyOrdering(filter).TagWith("List customers filtered by user inputs.");
    }
}
