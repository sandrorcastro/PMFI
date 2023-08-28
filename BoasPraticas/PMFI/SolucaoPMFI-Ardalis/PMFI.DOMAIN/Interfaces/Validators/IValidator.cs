using PMFI.Domain.Interfaces.Specifications;

namespace PMFI.Domain.Interfaces.Validators;

public interface IValidator
{
    bool IsValid<T>(T entity, ISpecification<T> specification);
}
