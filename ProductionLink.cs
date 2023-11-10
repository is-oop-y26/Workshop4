using FluentChaining;

internal class ProductionLink : ILink<string, IApplicationState>
{
    public IApplicationState Process(
        string request,
        SynchronousContext context,
        LinkDelegate<string, SynchronousContext, IApplicationState> next)
    {
        if (request.Equals(Environment.Production.ToString("G"),
                StringComparison.OrdinalIgnoreCase))
        {
            return new ProductionState();
        }

        return next(request, context);
    }
}