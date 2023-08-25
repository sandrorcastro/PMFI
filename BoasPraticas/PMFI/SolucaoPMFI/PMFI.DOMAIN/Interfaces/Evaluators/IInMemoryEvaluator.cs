using PMFI.Domain.Interfaces.Specifications;
using System.Collections.Generic;

namespace PMFI.Domain.Interfaces.Evaluators;

public interface IInMemoryEvaluator
{
    IEnumerable<T> Evaluate<T>(IEnumerable<T> query, ISpecification<T> specification);
}
