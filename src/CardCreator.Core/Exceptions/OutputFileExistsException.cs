namespace CardCreator.Core.Exceptions;

public class OutputFileExistsException : CardCreatorException
{
    public OutputFileExistsException(string outputFilePath)
        : base($"Output file already exists: {outputFilePath}")
    {
        OutputFilePath = outputFilePath;
    }

    public string OutputFilePath { get; }
}
