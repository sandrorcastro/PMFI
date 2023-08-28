using PMFI.Domain.Interfaces.Builder;

namespace PMFI.Domain.Interfaces.Buider;

public interface ICacheSpecificationBuilder<T> : ISpecificationBuilder<T> where T : class
{
    bool IsChainDiscarded { get; set; }
}
