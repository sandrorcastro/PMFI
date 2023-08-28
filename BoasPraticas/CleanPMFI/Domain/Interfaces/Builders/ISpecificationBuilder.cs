using Domain.Interfaces.Specifications;
using Domain.Specifications;

namespace Domain.Interfaces.Builders;
public interface ISpecificationBuilder<T, TResult> : ISpecificationBuilder<T>
{
    new Specification<T, TResult> Specification { get; }
}

public interface ISpecificationBuilder<T>
{
    Specification<T> Specification { get; }
}
