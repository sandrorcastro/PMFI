using Domain.Builders;
using Domain.Entities;
using Domain.Entities.DBProsiga;
using Domain.Filters.DBProsiga;
using Domain.Specifications;
using System.Linq.Expressions;

namespace Domain.Specs.DBProsiga;

public class AutoNumAnoNumeroSpec : SingleResultSpecification<AutoNumAnoNumero>
{
    
    public AutoNumAnoNumeroSpec(short AutoAno,string AutoTipo)

    {
        //InscricaoImobiliaria = _cpfcnpj;
        Query.Where(x => x.AutAno == AutoAno && x.AutTipo==AutoTipo);
        
        
    }   
    public AutoNumAnoNumeroSpec(ContribuinteFilter contribuinteFilter)
    {

       //Query.Where(x => x.ConCnpjcpf == contribuinteFilter.CPFCNPJ);

    }
    /*public Expression<Func<TribEdificaco, bool>> ToExpression()
    {
            return x => x.InscricaoImobiliaria == InscricaoImobiliaria;
        }*/

    
}
