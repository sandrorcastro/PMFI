﻿using Domain.Interfaces.Evaluators;
using Domain.Interfaces.Specifications;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Evaluators;

public class SearchEvaluator : IInMemoryEvaluator
{
    private SearchEvaluator() { }
    public static SearchEvaluator Instance { get; } = new SearchEvaluator();

    public IEnumerable<T> Evaluate<T>(IEnumerable<T> query, ISpecification<T> specification)
    {
        foreach (var searchGroup in specification.SearchCriterias.GroupBy(x => x.SearchGroup))
        {
            query = query.Where(x => searchGroup.Any(c => c.SelectorFunc(x).Like(c.SearchTerm)));
        }

        return query;
    }
}
