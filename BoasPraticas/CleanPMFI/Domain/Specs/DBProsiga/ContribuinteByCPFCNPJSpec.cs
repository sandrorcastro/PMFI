using Domain.Builders;
using Domain.Entities;
using Domain.Entities.DBProsiga;
using Domain.Filters.DBProsiga;
using Domain.Specifications;
using System.Linq.Expressions;

namespace Domain.Specs.DBProsiga;

public class ContribuinteByCPFCNPJSpec : SingleResultSpecification<Contribuinte>
{
    
    public ContribuinteByCPFCNPJSpec(string cpfcnpj)

    {
        //InscricaoImobiliaria = _cpfcnpj;
        Query.Where(x => x.ConCnpjcpf == cpfcnpj).Include(i => i.ConBairro).Include(i => i.TribEdificacoesContribs).Include(i => i.ConCidade).ThenInclude(i => i.Pais);
        
    }   
    public ContribuinteByCPFCNPJSpec(ContribuinteFilter contribuinteFilter)
    {

        Query.Where(x => x.ConCnpjcpf == contribuinteFilter.CPFCNPJ);

    }
    /*public Expression<Func<TribEdificaco, bool>> ToExpression()
    {
            return x => x.InscricaoImobiliaria == InscricaoImobiliaria;
        }*/

    
}
