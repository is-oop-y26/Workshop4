internal class ProductionState : IApplicationState
{
    public Environment CurrentEnvironment => Environment.Production;
    
    public void ListCommands()
    {
        Console.WriteLine("There is only ListCommands command.");
    }

    public void SayHello()
    {
        throw new InvalidOperationException(
            $"This command does not supposed to be used in {nameof(ProductionState)}");
    }
}