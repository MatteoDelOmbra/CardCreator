namespace CardCreator.Core.Templates;

public enum ThemeFallbackReason
{
    NotSelected,
    NotSupportedByCardType
}

/// <param name="RequestedTheme">Theme from the input file; null when not selected.</param>
/// <param name="UsedTheme">Default theme that was used instead.</param>
public record ThemeFallback(string? RequestedTheme, string UsedTheme, ThemeFallbackReason Reason);
