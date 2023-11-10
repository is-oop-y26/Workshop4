internal interface IApplicationState
{
    Environment CurrentEnvironment { get; }

    void ListCommands();

    void SayHello();
}