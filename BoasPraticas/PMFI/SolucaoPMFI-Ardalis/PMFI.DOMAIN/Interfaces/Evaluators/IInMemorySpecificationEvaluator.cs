using PMFI.Domain.Interfaces.Specifications;
using System.Collections.Generic;

namespace PMFI.Domain.Interfaces.Evaluators;

public interface IInMemorySpecificationEvaluator
{
    IEnumerable<TResult> Evaluate<T, TResult>(IEnumerable<T> source, ISpecification<T, TResult> specification);
    IEnumerable<T> Evaluate<T>(IEnumerable<T> source, ISpecification<T> specification);
}
