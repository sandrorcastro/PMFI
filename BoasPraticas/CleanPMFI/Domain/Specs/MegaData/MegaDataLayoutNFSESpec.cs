using Domain.Builders;
using Domain.Entities;
using Domain.Entities.MegaData;
using Domain.Entities.NFSEDB;
using Domain.Filters;
using Domain.Specifications;

namespace Domain.Specs;
public class MegaDataLayoutNFSESpec : Specification<NfseTblNfse>
{
    IQueryable<NfseTblNfse> queryable;
    public MegaDataLayoutNFSESpec()
    {
        Query.ApplyOrdering().TagWith("Lista todas as Notas Fiscais Eletrônicas");
    }
    public MegaDataLayoutNFSESpec(NfseTblNfseFilter filter)
    {
        Query.Where(c => c.Dtcompetencia >= filter.DataInicial && c.Dtcompetencia < filter.DataFinal); //.ApplyOrdering(filter).TagWith("Notas Fiscais No Período desejado!");
        //queryable.Join()
    }
}
