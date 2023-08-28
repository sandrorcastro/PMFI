using PMFI.Domain.Interfaces.Specifications;

namespace PMFI.Domain.Interfaces.Validators;

public interface ISpecificationValidator
{
    bool IsValid<T>(T entity, ISpecification<T> specification);
}
