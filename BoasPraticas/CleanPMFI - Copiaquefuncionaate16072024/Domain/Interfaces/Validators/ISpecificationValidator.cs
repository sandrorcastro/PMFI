using Domain.Interfaces.Specifications;

namespace Domain.Interfaces.Validators;

public interface ISpecificationValidator
{
    bool IsValid<T>(T entity, ISpecification<T> specification);
}
