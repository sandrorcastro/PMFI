using PMFI.Domain.Interfaces.Specifications;
using System.Linq;

namespace PMFI.Domain.Interfaces.Evaluators;

public interface IEvaluator
{
    bool IsCriteriaEvaluator { get; }

    IQueryable<T> GetQuery<T>(IQueryable<T> query, ISpecification<T> specification) where T : class;
}
