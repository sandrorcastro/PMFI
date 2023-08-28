using PMFI.Domain.Interfaces.Builder;

namespace PMFI.Domain.Interfaces.Buider;

public interface IOrderedSpecificationBuilder<T> : ISpecificationBuilder<T>
{
    bool IsChainDiscarded { get; set; }
}
