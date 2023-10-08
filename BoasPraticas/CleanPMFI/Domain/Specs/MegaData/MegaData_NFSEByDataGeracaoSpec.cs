using Domain.Builders;
using Domain.Entities;
using Domain.Entities.MegaData;
using Domain.Filters;
using Domain.Specifications;

namespace Domain.Specs;

public class MegaData_NFSEByDataGeracaoSpec : SingleResultSpecification<MegaData_NFSE>
{
    public MegaData_NFSEByDataGeracaoSpec(DateTime id)
    {
        Query.Where(x => x.DataGeracao == id);
    }
    public MegaData_NFSEByDataGeracaoSpec(MegaData_NFSEFilter Filter)
    {
        Query.Where(x => x.DataGeracao == Filter.DataGeracao);
        
    }
}
