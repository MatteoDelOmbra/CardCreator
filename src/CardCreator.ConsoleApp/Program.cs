using System.CommandLine;
using CardCreator.ConsoleApp.Commands;

var rootCommand = new RootCommand("Creates printable RPG cards (PDF) from a JSON card set definition.")
{
    GenerateCommand.Create(),
    ListCommand.Create()
};

return rootCommand.Parse(args).Invoke();
