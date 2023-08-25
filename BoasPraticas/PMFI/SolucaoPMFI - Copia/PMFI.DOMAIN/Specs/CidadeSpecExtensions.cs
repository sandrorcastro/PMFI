﻿using PMFI.Domain.Filters;


namespace PMFI.Domain.Specs;

// Examples how to add extend specifications.
// These extensions are applied in PMFI.Sample.Domain.Specs.CidadeSpec
public static class CidadeSpecExtensions
{
    // Let's assume we want to apply ordering for customers.
    // Conveniently, we can create add an extension method, and use it in any customer spec.
    public static ISpecificationBuilder<Cidade> ApplyOrdering(this ISpecificationBuilder<Cidade> builder, BaseFilter? filter = null)
    {
        // If there is no filter apply default ordering;
        if (filter is null) return builder.OrderBy(x => x.Id);

        // We want the "asc" to be the default, that's why the condition is reverted.
        var isAscending = !(filter.OrderBy?.Equals("desc", StringComparison.OrdinalIgnoreCase) ?? false);

        return filter.SortBy switch
        {
            nameof(Cidade.Name) => isAscending ? builder.OrderBy(x => x.Name) : builder.OrderByDescending(x => x.Name),
            nameof(Cidade.Age) => isAscending ? builder.OrderBy(x => x.Age) : builder.OrderByDescending(x => x.Age),
            _ => builder.OrderBy(x => x.Id)
        };
    }

    // More complex scenario would be if we want to add a new feature.
    // Let's say we want to add a capability for query tags. We can utilize the Items dictionary in the specification to store the tag.
    // Once we have this in place, we would also need to add an evaluator in SpecificationEvaluator (check the example in Sample.App2)
    public static ISpecificationBuilder<Cidade> TagWith(this ISpecificationBuilder<Cidade> builder, string tag)
    {
        builder.Specification.Items.TryAdd("TagWith", tag);
        return builder;
    }
}