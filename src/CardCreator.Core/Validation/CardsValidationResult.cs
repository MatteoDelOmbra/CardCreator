using CardCreator.Core.Input;

namespace CardCreator.Core.Validation;

public record CardsValidationResult(
    IReadOnlyList<CardEntry> ValidCards,
    IReadOnlyList<CardValidationError> InvalidCards)
{
    public bool HasInvalidCards => InvalidCards.Count > 0;
}
