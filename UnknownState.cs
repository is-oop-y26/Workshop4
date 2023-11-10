internal class UnknownState : IApplicationState
{
    public Environment CurrentEnvironment => Environment.Unknown;
    
    public void ListCommands()
    {
        throw new NotImplementedException();
    }

    public void SayHello()
    {
        throw new NotImplementedException();
    }
}