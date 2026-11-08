using System.CommandLine;

namespace CardCreator.ConsoleApp.Commands;

/// <summary>
/// cardcreator generate &lt;json-file&gt; [--yes]
/// </summary>
public static class GenerateCommand
{
    public static Command Create()
    {
        var jsonFileArgument = new Argument<FileInfo>("json-file")
        {
            Description = "Path to the card set JSON file."
        };

        var yesOption = new Option<bool>("--yes", "-y")
        {
            Description = "Do not ask for confirmation; skip invalid cards and generate the valid ones."
        };

        var command = new Command("generate", "Generates a printable PDF from a card set JSON file.")
        {
            jsonFileArgument,
            yesOption
        };

        command.SetAction(parseResult => Execute(
            parseResult.GetValue(jsonFileArgument)!,
            parseResult.GetValue(yesOption)));

        return command;
    }

    private static int Execute(FileInfo jsonFile, bool skipInvalidCardsWithoutAsking)
    {
        throw new NotImplementedException();
    }
}
