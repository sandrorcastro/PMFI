﻿using System.Linq;

namespace PMFI.Specification;

public interface IEvaluator
{
    bool IsCriteriaEvaluator { get; }

    IQueryable<T> GetQuery<T>(IQueryable<T> query, ISpecification<T> specification) where T : class;
}
