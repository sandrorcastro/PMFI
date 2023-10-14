using Domain.Builders;
using Domain.Entities;
using Domain.Entities.MegaData;
using Domain.Filters;
using Domain.Specifications;

namespace Domain.Specs;
public class MegaData_NFSESpec : Specification<MegaData_NFSE>
{
    IQueryable<MegaData_NFSE> queryable;
    public MegaData_NFSESpec()
    {
        Query.ApplyOrdering().TagWith("Lista todos os Períodos");
        
    }
    public MegaData_NFSESpec(MegaData_NFSEFilter filter)

    {
        
        Query.Where(c => c.DataGeracao >= filter.DataGeracao).ApplyOrdering(filter).TagWith("Lista todos os Períodos");
        //Query
    }
}
