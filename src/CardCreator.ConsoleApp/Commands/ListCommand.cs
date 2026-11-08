using System.CommandLine;

namespace CardCreator.ConsoleApp.Commands;

/// <summary>
/// cardcreator list — prints supported games, their themes, card types and card sizes.
/// </summary>
public static class ListCommand
{
    public static Command Create()
    {
        var command = new Command("list", "Lists supported games, themes, card types and card sizes.");

        command.SetAction(_ => Execute());

        return command;
    }

    private static int Execute()
    {
        throw new NotImplementedException();
    }
}
