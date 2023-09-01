using Infrastructure.Evaluators;

namespace WEBMVC;

// This evaluator will be passed to the repositories.
public class AppSpecificationEvaluator : SpecificationEvaluator
{
    public static AppSpecificationEvaluator Instance { get; } = new AppSpecificationEvaluator();

    public AppSpecificationEvaluator() : base()
    {
        Evaluators.Add(QueryTagEvaluator.Instance);
    }
}
