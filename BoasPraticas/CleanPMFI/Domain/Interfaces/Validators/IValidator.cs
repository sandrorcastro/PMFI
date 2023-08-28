﻿using Domain.Interfaces.Specifications;

namespace Domain.Interfaces.Validators;
public interface IValidator
{
    bool IsValid<T>(T entity, ISpecification<T> specification);
}
