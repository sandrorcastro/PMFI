using PMFI.Domain.Interfaces.Builder;

namespace PMFI.Domain.Interfaces.Buider;

public interface IIncludableSpecificationBuilder<T, out TProperty> : ISpecificationBuilder<T> where T : class
{
    bool IsChainDiscarded { get; set; }
}
