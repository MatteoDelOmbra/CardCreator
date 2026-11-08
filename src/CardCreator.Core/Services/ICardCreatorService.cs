namespace CardCreator.Core.Services;

/// <summary>
/// Entry point of the library. Generation is split in two steps so the caller can decide
/// what to do with invalid cards before the PDF is created.
/// </summary>
public interface ICardCreatorService
{
    /// <summary>
    /// Loads and validates the input file, checks the output file does not exist and resolves templates.
    /// </summary>
    /// <exception cref="Exceptions.CardSetValidationException">Card set definition is invalid.</exception>
    /// <exception cref="Exceptions.OutputFileExistsException">Output file already exists.</exception>
    PreparedCardSet Prepare(string jsonFilePath);

    /// <summary>Generates the PDF from valid cards only. Creates the output directory if needed.</summary>
    void Generate(PreparedCardSet cardSet);
}
