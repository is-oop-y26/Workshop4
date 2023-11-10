using FluentChaining;

internal class DevelopmentLink : ILink<string, IApplicationState>
{
    public IApplicationState Process(
        string request,
        SynchronousContext context,
        LinkDelegate<string, SynchronousContext, IApplicationState> next)
    {
        if (request.Equals(Environment.Development.ToString("G")
                , StringComparison.OrdinalIgnoreCase))
        {
            return new LocalState();
        }

        return next(request, context);
    }
}