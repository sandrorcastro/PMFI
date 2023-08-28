using PMFI.Domain.Interfaces.Specifications;

namespace PMFI.Domain.Specifications;

/// <inheritdoc cref="ISingleResultSpecification{T}"/>
public class SingleResultSpecification<T> : Specification<T>, ISingleResultSpecification<T>
{
}

/// <inheritdoc cref="ISingleResultSpecification{T, TResult}"/>
public class SingleResultSpecification<T, TResult> : Specification<T, TResult>, ISingleResultSpecification<T, TResult>
{
}
