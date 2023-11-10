internal class LocalState : IApplicationState
{
    public Environment CurrentEnvironment => Environment.Development;
   
    public void ListCommands()
    {
        Console.WriteLine("--help = List Commands");
        Console.WriteLine("--hello = Say hello");
    }

    public void SayHello()
    {
        Console.WriteLine("Hello");
    }
}