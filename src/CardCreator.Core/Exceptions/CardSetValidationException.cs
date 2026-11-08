namespace CardCreator.Core.Exceptions;

/// <summary>
/// Thrown when the card set definition itself (not individual cards) is invalid,
/// e.g. unsupported game/theme/card type/size or malformed root properties.
/// </summary>
public class CardSetValidationException : CardCreatorException
{
    public CardSetValidationException(IReadOnlyList<string> errors)
        : base("Card set definition is invalid.")
    {
        Errors = errors;
    }

    public IReadOnlyList<string> Errors { get; }
}
