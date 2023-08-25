using PMFI.Domain.Specifications;

namespace PMFI.Domain.Interfaces.Builder;

public interface ISpecificationBuilder<T, TResult> : ISpecificationBuilder<T>
{
    new Specification<T, TResult> Specification { get; }
}

public interface ISpecificationBuilder<T>
{
    Specification<T> Specification { get; }
}
