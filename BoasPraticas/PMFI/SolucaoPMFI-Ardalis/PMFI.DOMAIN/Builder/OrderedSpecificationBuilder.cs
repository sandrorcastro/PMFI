using PMFI.Domain.Interfaces.Buider;
using PMFI.Domain.Specifications;

namespace PMFI.Domain.Builder;

public class OrderedSpecificationBuilder<T> : IOrderedSpecificationBuilder<T>
{
    public Specification<T> Specification { get; }
    public bool IsChainDiscarded { get; set; }

    public OrderedSpecificationBuilder(Specification<T> specification)
        : this(specification, false)
    {
    }

    public OrderedSpecificationBuilder(Specification<T> specification, bool isChainDiscarded)
    {
        Specification = specification;
        IsChainDiscarded = isChainDiscarded;
    }
}
