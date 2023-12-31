﻿using Domain.Evaluators;
using Domain.Interfaces.Specifications;
using Domain.Interfaces.Validators;
using System.Linq;

namespace Domain.Validators;

public class SearchValidator : IValidator
{
    private SearchValidator() { }
    public static SearchValidator Instance { get; } = new SearchValidator();

    public bool IsValid<T>(T entity, ISpecification<T> specification)
    {
        foreach (var searchGroup in specification.SearchCriterias.GroupBy(x => x.SearchGroup))
        {
            if (searchGroup.Any(c => c.SelectorFunc(entity).Like(c.SearchTerm)) == false) return false;
        }

        return true;
    }
}
