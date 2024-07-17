using Domain.Interfaces.Specifications;
using System.Linq;

namespace Domain.Interfaces.Evaluators;

public interface IEvaluator
{
    bool IsCriteriaEvaluator { get; }

    IQueryable<T> GetQuery<T>(IQueryable<T> query, ISpecification<T> specification) where T : class;
}
