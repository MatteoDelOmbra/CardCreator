namespace CardCreator.Core.Exceptions;

public class CardCreatorException : Exception
{
    public CardCreatorException(string message) : base(message) { }

    public CardCreatorException(string message, Exception innerException) : base(message, innerException) { }
}
