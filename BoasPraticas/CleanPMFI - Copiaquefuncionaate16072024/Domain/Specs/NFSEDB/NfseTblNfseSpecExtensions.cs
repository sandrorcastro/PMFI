using Domain.Builders;
using Domain.Entities;
using Domain.Entities.MegaData;
using Domain.Entities.NFSEDB;
using Domain.Filters;
using Domain.Interfaces.Builders;

namespace Domain.Specs;

// Examples how to add extend specifications.
// These extensions are applied in Ardalis.Sample.Domain.Specs.CustomerSpec
public static class NfseTblNfseSpecExtensions
{
    // Let's assume we want to apply ordering for customers.
    // Conveniently, we can create add an extension method, and use it in any customer spec.
    public static ISpecificationBuilder<NfseTblNfse> ApplyOrdering(this ISpecificationBuilder<NfseTblNfse> builder, BaseFilter? filter = null)
    {
        // If there is no filter apply default ordering;
        if (filter is null) return builder.OrderBy(x => x.Dtcompetencia);
        //if (filter is null) return builder.OrderByDescending(x => x.Nome);

        // We want the "asc" to be the default, that's why the condition is reverted.
        var isAscending = !(filter.OrderBy?.Equals("desc", StringComparison.OrdinalIgnoreCase) ?? false);

        return filter.SortBy switch
        {
            nameof(NfseTblNfse.Dtcompetencia) => isAscending ? builder.OrderBy(x => x.Dtcompetencia) : builder.OrderByDescending(x => x.Dtcompetencia)
            /*,
            nameof(Pais.IdPais) => isAscending ? builder.OrderBy(x => x.IdPais) : builder.OrderByDescending(x => x.IdPais)*/,

            _ => builder.OrderByDescending(x => x.Dtcompetencia)
          
        };
    }

    // More complex scenario would be if we want to add a new feature.
    // Let's say we want to add a capability for query tags. We can utilize the Items dictionary in the specification to store the tag.
    // Once we have this in place, we would also need to add an evaluator in SpecificationEvaluator (check the example in Sample.App2)
    public static ISpecificationBuilder<NfseTblNfse> TagWith(this ISpecificationBuilder<NfseTblNfse> builder, string tag)
    {
        builder.Specification.Items.TryAdd("TagWith", tag);
        return builder;
    }
   
}
