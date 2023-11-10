using CommandLine;

namespace Lecture8;

public class CliCommands
{
    [Option("env")]
    public string Environment { get; set; }
    
    [Option("help")]
    public bool WantHelp { get; set; }
    
    [Option("hello")]
    public bool ShouldSayHello { get; set; }
}