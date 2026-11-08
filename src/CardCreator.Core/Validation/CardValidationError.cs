namespace CardCreator.Core.Validation;

/// <summary>
/// Validation errors for one card, identified by its index in the "cards" array and its name (if present).
/// </summary>
public record CardValidationError(int Index, string? Name, IReadOnlyList<string> Errors);
